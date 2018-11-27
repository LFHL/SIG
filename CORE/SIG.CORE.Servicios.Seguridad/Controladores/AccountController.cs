using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SIG.CORE.Seguridad.Entidades;
using SIG.CORE.Servicios.Seguridad.Modelos;

namespace SIG.CORE.Servicios.Seguridad.Controladores
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly IConfiguration _configuration;
        
        protected AccountController(
            UserManager<Usuario> userManager,
            SignInManager<Usuario> signInManager,
            IConfiguration configuration )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _userManager.Users.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Usuario> Get( int id )
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }


        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> CreateUser( [FromBody] UserInfo model )
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario
                {
                    UserName = model.Usuario,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return BuildToken(model);
                }
                else
                {
                    return BadRequest("Username or Password invalid");
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login( [FromBody] UserInfo model )
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if (result.Succeeded)
                {
                    return BuildToken(model);
                }
                /*
                else if (result.RequiresTwoFactor)
                {
                    return RedirectToAction(nameof(LoginWith2fa), new { returnUrl, model.RememberMe });
                }
                */
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError(string.Empty, "La cuenta de usuario ha sido bloqueada.");
                    return BadRequest(ModelState);
                    /*
                    _logger.LogWarning("User account locked out.");
                    return RedirectToAction(nameof(Lockout));
                    */
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Intento de autenticación fallido.");
                    return BadRequest(ModelState);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        private IActionResult BuildToken( UserInfo model )
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, model.Email),
                new Claim("Mi Valor", "Lo que yo quiera"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Mi_Llave_Super_Secreta"]));
            var Credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            DateTime? expiration = DateTime.UtcNow.AddHours(1);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: "MyCompany.Com",
                audience: "Sistema.SIG",
                claims: claims,
                expires: expiration,
                signingCredentials: Credenciales
                );

            var resultado = new { token = new JwtSecurityTokenHandler().WriteToken(token), expiration };

            return base.Ok(resultado);
        }
    }
}

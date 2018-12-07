using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Servicios.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ClientesController : ControllerBase
    {
        private readonly IServicioCliente _Clientes;
        public ClientesController( IServicioCliente customerService )
        {
            _Clientes = customerService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            ///Customers with all there orders? NO
            return _Clientes.ListarTodos();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get( int id )
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            //return _customerService.BuscarPorId(id);
            return _Clientes.BuscarPorIdIncluirOrdenes(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Cliente> Post( [FromBody] Cliente value )
        {
            if (string.IsNullOrEmpty(value.Nombres))
            {
                return BadRequest("Firstname is Required for Creating Customer");
            }

            if (string.IsNullOrEmpty(value.Apellidos))
            {
                return BadRequest("LastName is Required for Creating Customer");
            }
            //return StatusCode(503, "Horrible Error CALL Tech Support");
            var actualValue = _Clientes.Crear(value);
            return CreatedAtAction("GET", new { id = actualValue.Id }, actualValue);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Cliente> Put( int id, [FromBody] Cliente value )
        {
            if (id < 1 || id != value.Id)
            {
                return BadRequest("Parameter Id and customer ID must be the same");
            }

            return Ok(_Clientes.Actualizar(value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Cliente> Delete( int id )
        {
            var customer = _Clientes.Eliminar(id);
            if (customer == null)
            {
                return StatusCode(404, "Did not find Customer with ID " + id);
            }

            return Ok($"Customer with Id: {id} is Deleted");
        }
    }
}

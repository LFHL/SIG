using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIG.CORE.Persistencia.EF.Extensiones;
using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Persistencia.EF.Modelo
{
    public class ContextoSeguridad : IdentityDbContext<Usuario,Rol,int>
    {
        public ContextoSeguridad( DbContextOptions<ContextoSeguridad> options )
            : base(options)
        {
        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
            builder.AplicarConfiguracionesDeSeguridad();
        }
    }
}

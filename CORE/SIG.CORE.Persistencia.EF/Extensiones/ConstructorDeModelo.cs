using System;
using Microsoft.EntityFrameworkCore;
using SIG.CORE.Persistencia.EF.Configuraciones.Seguridad;

namespace SIG.CORE.Persistencia.EF.Extensiones
{
    public static class ConstructorDeModelo
    {
        public static void AplicarConfiguracionesDeSeguridad( this ModelBuilder builder )
        {
            builder.ApplyConfiguration(new ConfiguracionUsuario());
            builder.ApplyConfiguration(new ConfiguracionRol());
            builder.ApplyConfiguration(new ConfiguracionRolesUsuario());
            builder.ApplyConfiguration(new ConfiguracionLoginsUsuario());
            builder.ApplyConfiguration(new ConfiguracionPerfilesUsuario());
            builder.ApplyConfiguration(new ConfiguracionTokensUsuario());
            builder.ApplyConfiguration(new ConfiguracionPerfilesRol());
        }
    }
}

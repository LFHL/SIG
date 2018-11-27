using Microsoft.EntityFrameworkCore;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Configuraciones;
using SIG.FCT.Persistencia.EF.Extensiones;

namespace SIG.FCT.Persistencia.EF.Modelo
{
    public class ContextoEnMemoria : DbContext
    {
        public ContextoEnMemoria( DbContextOptions<ContextoEnMemoria> options )
            : base(options)
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            //base.OnModelCreating(modelBuilder);
            // TODO: Descomentar cuando actualice a .NetCore 2.2 y comentar el resto
            modelBuilder.ApplyAllConfigurations();
            modelBuilder.ApplyConfiguration(new ConfiguracionCliente());
            modelBuilder.ApplyConfiguration(new ConfiguracionOrden());
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Orden> Ordenes { get; set; }
    }
}



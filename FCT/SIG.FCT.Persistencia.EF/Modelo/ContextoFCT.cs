using Microsoft.EntityFrameworkCore;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Configuraciones;
using SIG.FCT.Persistencia.EF.Extensiones;

namespace SIG.FCT.Persistencia.EF.Modelo
{
    public class ContextoFCT : DbContext
    {
        public ContextoFCT( DbContextOptions<ContextoFCT> options )
            : base(options)
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            //base.OnModelCreating(modelBuilder);            
            modelBuilder.ApplyAllConfigurations();
            //ContextoFCTInitializer.Initialize();
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Orden> Ordenes { get; set; }
    }
}



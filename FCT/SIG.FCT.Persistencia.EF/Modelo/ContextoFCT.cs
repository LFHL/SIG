using Microsoft.EntityFrameworkCore;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.CORE.Entidades.Fct;
using SIG.FCT.CORE.Entidades.Gbl;
using SIG.FCT.CORE.Entidades.Inv;
using SIG.FCT.CORE.Entidades.Par;
using SIG.FCT.CORE.Entidades.Tbl;
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

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            //base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=defaultConnection");
                //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            //base.OnModelCreating(modelBuilder);            
            modelBuilder.ApplyAllConfigurations();
           //ContextoFCTInitializer.Initialize();

        }


        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Orden> Ordenes { get; set; }

        public virtual DbSet<ActividadesEconomicas> FctActividadesEconomicas { get; set; }
        public virtual DbSet<AsignacionesSistema> FctAsignacionesSistema { get; set; }
        public virtual DbSet<Dosificaciones> FctDosificaciones { get; set; }
        public virtual DbSet<CORE.Entidades.Fct.Empresas> FctEmpresas { get; set; }
        public virtual DbSet<Facturas> FctFacturas { get; set; }
        public virtual DbSet<Reimpresiones> FctReimpresiones { get; set; }
        public virtual DbSet<SistemasFacturacion> FctSistemasFacturacion { get; set; }
        public virtual DbSet<Sucursales> FctSucursales { get; set; }
        public virtual DbSet<Direcciones> GblDirecciones { get; set; }
        public virtual DbSet<CORE.Entidades.Gbl.Empresas> GblEmpresas { get; set; }
        public virtual DbSet<Imagenes> GblImagenes { get; set; }
        public virtual DbSet<Personas> GblPersonas { get; set; }
        public virtual DbSet<PropiedadesContacto> GblPropiedadesContacto { get; set; }
        public virtual DbSet<Clientes> InvClientes { get; set; }
        public virtual DbSet<Compras> InvCompras { get; set; }
        public virtual DbSet<DetalleCompras> InvDetalleCompras { get; set; }
        public virtual DbSet<DetalleVentas> InvDetalleVentas { get; set; }
        public virtual DbSet<Productos> InvProductos { get; set; }
        public virtual DbSet<SubProductos> InvSubProductos { get; set; }
        public virtual DbSet<Ventas> InvVentas { get; set; }
        public virtual DbSet<CategoriasProducto> ParCategoriasProducto { get; set; }
        public virtual DbSet<Generales> ParGenerales { get; set; }
        public virtual DbSet<TiposObjeto> ParTiposObjeto { get; set; }
        public virtual DbSet<Personal> TblPersonal { get; set; }

        // Unable to generate entity type for table 'dbo.FCT_TiposEmisor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GBL_RelacionDatosContacto'. Please see the warning messages.

    }
}



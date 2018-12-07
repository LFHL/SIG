using System;
using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.CORE.Entidades.Fct;
using SIG.FCT.CORE.Entidades.Gbl;
using SIG.FCT.CORE.Entidades.Inv;
using SIG.FCT.CORE.Entidades.Par;
using SIG.FCT.CORE.Entidades.Tbl;
using SIG.FCT.Persistencia.EF.Modelo;
using SIG.FCT.Persistencia.EF.Repositorios;

namespace SIG.FCT.Persistencia.EF.Base
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly ContextoFCT _contexto;

        #region Facturacion
        public virtual IRepositorio<ActividadesEconomicas> FctActividadesEconomicas { get; }
        public virtual IRepositorio<AsignacionesSistema> FctAsignacionesSistema { get; }
        public virtual IRepositorio<Dosificaciones> FctDosificaciones { get; }
        public virtual IRepositorio<CORE.Entidades.Fct.Empresas> FctEmpresas { get; }
        public virtual IRepositorio<Facturas> FctFacturas { get; }
        public virtual IRepositorio<Reimpresiones> FctReimpresiones { get; }
        public virtual IRepositorio<SistemasFacturacion> FctSistemasFacturacion { get; }
        public virtual IRepositorio<Sucursales> FctSucursales { get; }
        #endregion

        #region Global
        public virtual IRepositorio<Direcciones> GblDirecciones { get; }
        public virtual IRepositorio<CORE.Entidades.Gbl.Empresas> GblEmpresas { get; }
        public virtual IRepositorio<Imagenes> GblImagenes { get; }
        public virtual IRepositorio<Personas> GblPersonas { get; }
        public virtual IRepositorio<PropiedadesContacto> GblPropiedadesContacto { get; }
        #endregion

        #region Inventarios
        public virtual IRepositorio<Clientes> InvClientes { get; }
        public virtual IRepositorio<Compras> InvCompras { get; }
        public virtual IRepositorio<DetalleCompras> InvDetalleCompras { get; }
        public virtual IRepositorio<DetalleVentas> InvDetalleVentas { get; }
        public virtual IRepositorio<Productos> InvProductos { get; }
        public virtual IRepositorio<SubProductos> InvSubProductos { get; }
        public virtual IRepositorio<Ventas> InvVentas { get; }
        #endregion

        #region Parametros
        public virtual IRepositorio<CategoriasProducto> ParCategoriasProducto { get; }
        public virtual IRepositorio<Generales> ParGenerales { get; }
        public virtual IRepositorio<TiposObjeto> ParTiposObjeto { get; }
        #endregion

        #region Tablas varias
        public IRepositorioCliente Clientes { get; }
        public IRepositorio<Orden> Ordenes { get; }
        public virtual IRepositorio<Personal> TblPersonal { get; }
        #endregion

        public UnidadDeTrabajo() : this(true)
        {
        }

        public UnidadDeTrabajo( bool EnMemoria = false )
        {

            const string conectionString = "Server=(localdb)\\mssqllocaldb;Database=SIG_FCT_DB;Trusted_Connection=True;MultipleActiveResultSets=true";
            var factory = new AppDbContextFactory();
            _contexto = EnMemoria ? factory.CreateInMemory("FCT_Database") : factory.Create(conectionString);

            #region Facturacion
            FctActividadesEconomicas = new Repositorio<ActividadesEconomicas>(_contexto);
            FctAsignacionesSistema = new Repositorio<AsignacionesSistema>(_contexto);
            FctDosificaciones = new Repositorio<Dosificaciones>(_contexto);
            FctEmpresas = new Repositorio<CORE.Entidades.Fct.Empresas>(_contexto);
            FctFacturas = new Repositorio<Facturas>(_contexto);
            FctReimpresiones = new Repositorio<Reimpresiones>(_contexto);
            FctSistemasFacturacion = new Repositorio<SistemasFacturacion>(_contexto);
            FctSucursales = new Repositorio<Sucursales>(_contexto);
            #endregion

            #region Global
            GblDirecciones = new Repositorio<Direcciones>(_contexto);
            GblEmpresas = new Repositorio<CORE.Entidades.Gbl.Empresas>(_contexto);
            GblImagenes = new Repositorio<Imagenes>(_contexto);
            GblPersonas = new Repositorio<Personas>(_contexto);
            GblPropiedadesContacto = new Repositorio<PropiedadesContacto>(_contexto);
            #endregion

            #region Inventarios
            InvClientes = new Repositorio<Clientes>(_contexto);
            InvCompras = new Repositorio<Compras>(_contexto);
            InvDetalleCompras = new Repositorio<DetalleCompras>(_contexto);
            InvDetalleVentas = new Repositorio<DetalleVentas>(_contexto);
            InvProductos = new Repositorio<Productos>(_contexto);
            InvSubProductos = new Repositorio<SubProductos>(_contexto);
            InvVentas = new Repositorio<Ventas>(_contexto);
            #endregion

            #region Parametros
            ParCategoriasProducto = new Repositorio<CategoriasProducto>(_contexto);
            ParGenerales = new Repositorio<Generales>(_contexto);
            ParTiposObjeto = new Repositorio<TiposObjeto>(_contexto);
            #endregion

            #region Tablas varias
            Clientes = new RepositorioCliente(_contexto);
            Ordenes = new RepositorioOrden(_contexto);
            TblPersonal = new Repositorio<Personal>(_contexto);
            #endregion

            //ContextoFCTInitializer.Initialize(_contexto);
        }


        public int Guardar()
        {
            return _contexto.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose( bool disposing )
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
                disposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnidadDeTrabajo() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}

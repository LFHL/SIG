using System;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.CORE.Entidades.Fct;
using SIG.FCT.CORE.Entidades.Gbl;
using SIG.FCT.CORE.Entidades.Inv;
using SIG.FCT.CORE.Entidades.Par;
using SIG.FCT.CORE.Entidades.Tbl;

namespace SIG.FCT.CORE.Aplicacion.Contratos.Repositorio
{
    public interface IUnidadDeTrabajo : IDisposable
    {
      

        #region Facturacion
        IRepositorio<ActividadesEconomicas> FctActividadesEconomicas { get; }
        IRepositorio<AsignacionesSistema> FctAsignacionesSistema { get; }
        IRepositorio<Dosificaciones> FctDosificaciones { get; }
        IRepositorio<CORE.Entidades.Fct.Empresas> FctEmpresas { get; }
        IRepositorio<Facturas> FctFacturas { get; }
        IRepositorio<Reimpresiones> FctReimpresiones { get; }
        IRepositorio<SistemasFacturacion> FctSistemasFacturacion { get; }
        IRepositorio<Sucursales> FctSucursales { get; }
        #endregion

        #region Global
        IRepositorio<Direcciones> GblDirecciones { get; }
        IRepositorio<CORE.Entidades.Gbl.Empresas> GblEmpresas { get; }
        IRepositorio<Imagenes> GblImagenes { get; }
        IRepositorio<Personas> GblPersonas { get; }
        IRepositorio<PropiedadesContacto> GblPropiedadesContacto { get; }
        #endregion

        #region Inventarios
        IRepositorio<Clientes> InvClientes { get; }
        IRepositorio<Compras> InvCompras { get; }
        IRepositorio<DetalleCompras> InvDetalleCompras { get; }
        IRepositorio<DetalleVentas> InvDetalleVentas { get; }
        IRepositorio<Productos> InvProductos { get; }
        IRepositorio<SubProductos> InvSubProductos { get; }
        IRepositorio<Ventas> InvVentas { get; }
        #endregion


        #region Parametros
        IRepositorio<CategoriasProducto> ParCategoriasProducto { get; }
        IRepositorio<Generales> ParGenerales { get; }
        IRepositorio<TiposObjeto> ParTiposObjeto { get; }
        #endregion

        #region Tablas generales
        IRepositorioCliente Clientes { get; }
        IRepositorio<Orden> Ordenes { get; }
        IRepositorio<Personal> TblPersonal { get; }
        #endregion


        int Guardar();
    }
}

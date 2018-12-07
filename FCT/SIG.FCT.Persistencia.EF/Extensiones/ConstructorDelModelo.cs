using Microsoft.EntityFrameworkCore;
using SIG.FCT.Persistencia.EF.Configuraciones;
using fct = SIG.FCT.Persistencia.EF.Configuraciones.Fct;
using gbl = SIG.FCT.Persistencia.EF.Configuraciones.Gbl;
using inv = SIG.FCT.Persistencia.EF.Configuraciones.Inv;
using par = SIG.FCT.Persistencia.EF.Configuraciones.Par;
using tbl = SIG.FCT.Persistencia.EF.Configuraciones.Tbl;


namespace SIG.FCT.Persistencia.EF.Extensiones
{

    public static class ConstructorDelModelo
    {
        public static void ApplyAllConfigurations( this ModelBuilder modelBuilder )
        {
            #region Facturacion
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionActividadesEconomicas());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionAsignacionesSistema());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionDosificaciones());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionEmpresas());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionFacturas());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionReimpresiones());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionSistemasFacturacion());
            modelBuilder.ApplyConfiguration(new fct.ConfiguracionSucursales());
            #endregion

            #region Globales
            modelBuilder.ApplyConfiguration(new gbl.ConfiguracionDirecciones());
            modelBuilder.ApplyConfiguration(new gbl.ConfiguracionEmpresas());
            modelBuilder.ApplyConfiguration(new gbl.ConfiguracionImagenes());
            modelBuilder.ApplyConfiguration(new gbl.ConfiguracionPersonas());
            modelBuilder.ApplyConfiguration(new gbl.ConfiguracionPropiedadesContacto());
            #endregion

            #region Inventarios
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionCliente());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionCompras());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionDetalleCompras());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionDetalleVentas());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionProductos());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionSubProductos());
            modelBuilder.ApplyConfiguration(new inv.ConfiguracionVentas());
            #endregion

            #region Parametricas
            modelBuilder.ApplyConfiguration(new par.ConfiguracionCategoriasProducto());
            modelBuilder.ApplyConfiguration(new par.ConfiguracionGenerales());
            modelBuilder.ApplyConfiguration(new par.ConfiguracionTiposObjeto());
            #endregion

            #region Otras tablas
            modelBuilder.ApplyConfiguration(new tbl.ConfiguracionPersonal());
            modelBuilder.ApplyConfiguration(new ConfiguracionCliente());
            modelBuilder.ApplyConfiguration(new ConfiguracionOrden());
            #endregion

            // TODO: Descomentar cuando actualice a .NetCore 2.2 y comentar el resto
            /*
            var applyConfigurationMethodInfo = modelBuilder
                .GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .First(m => m.Name.Equals("ApplyConfiguration", StringComparison.OrdinalIgnoreCase));

            var ret = typeof(ContextoFCT).Assembly
                .GetTypes()
                .Select(t => (t, i: t.GetInterfaces().FirstOrDefault(i => i.Name.Equals(typeof(IEntityTypeConfiguration<>).Name, StringComparison.Ordinal))))
                .Where(it => it.i != null)
                // TODO: Descomentar cuando usemos DotNet Core 2.2
                //.Select(it => (et: it.i.GetGenericArguments()[0], cfgObj: Activator.CreateInstance(it.t)))
                //.Select(it => applyConfigurationMethodInfo.MakeGenericMethod(it.et).Invoke(modelBuilder, new[] { it.cfgObj }))
                .ToList();
            */
        }
    }
}

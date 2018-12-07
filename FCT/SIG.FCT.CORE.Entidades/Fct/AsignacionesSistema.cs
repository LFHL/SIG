using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class AsignacionesSistema
    {
        public AsignacionesSistema()
        {
            FctDosificaciones = new HashSet<Dosificaciones>();
        }

        public int Id { get; set; }
        public int? Sfc { get; set; }
        public int? IdActividadEconomica { get; set; }
        public int? NroSucursal { get; set; }
        public int? IdTipoEmisor { get; set; }
        public bool? Habilitado { get; set; }

        public ActividadesEconomicas IdActividadEconomicaNavigation { get; set; }
        public Generales IdTipoEmisorNavigation { get; set; }
        public Sucursales NroSucursalNavigation { get; set; }
        public SistemasFacturacion SfcNavigation { get; set; }
        public ICollection<Dosificaciones> FctDosificaciones { get; set; }
    }
}

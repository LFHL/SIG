using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctAsignacionesSistema
    {
        public FctAsignacionesSistema()
        {
            FctDosificaciones = new HashSet<FctDosificaciones>();
        }

        public int Id { get; set; }
        public int? Sfc { get; set; }
        public int? IdActividadEconomica { get; set; }
        public int? NroSucursal { get; set; }
        public int? IdTipoEmisor { get; set; }
        public bool? Habilitado { get; set; }

        public FctActividadesEconomicas IdActividadEconomicaNavigation { get; set; }
        public ParGenerales IdTipoEmisorNavigation { get; set; }
        public FctSucursales NroSucursalNavigation { get; set; }
        public FctSistemasFacturacion SfcNavigation { get; set; }
        public ICollection<FctDosificaciones> FctDosificaciones { get; set; }
    }
}

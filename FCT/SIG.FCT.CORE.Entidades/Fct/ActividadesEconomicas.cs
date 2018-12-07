using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctActividadesEconomicas
    {
        public FctActividadesEconomicas()
        {
            FctAsignacionesSistema = new HashSet<FctAsignacionesSistema>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool? Principal { get; set; }
        public bool? Habilitada { get; set; }

        public ICollection<FctAsignacionesSistema> FctAsignacionesSistema { get; set; }
    }
}

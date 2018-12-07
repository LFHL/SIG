using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class ActividadesEconomicas
    {
        public ActividadesEconomicas()
        {
            AsignacionesSistema = new HashSet<AsignacionesSistema>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool? Principal { get; set; }
        public bool? Habilitada { get; set; }

        public ICollection<AsignacionesSistema> AsignacionesSistema { get; set; }
    }
}

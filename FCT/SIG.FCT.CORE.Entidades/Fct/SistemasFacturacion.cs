using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class SistemasFacturacion
    {
        public SistemasFacturacion()
        {
            FctAsignacionesSistema = new HashSet<AsignacionesSistema>();
        }

        public int Sfc { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }

        public ICollection<AsignacionesSistema> FctAsignacionesSistema { get; set; }
    }
}

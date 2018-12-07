using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctSistemasFacturacion
    {
        public FctSistemasFacturacion()
        {
            FctAsignacionesSistema = new HashSet<FctAsignacionesSistema>();
        }

        public int Sfc { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }

        public ICollection<FctAsignacionesSistema> FctAsignacionesSistema { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctDosificaciones
    {
        public FctDosificaciones()
        {
            FctFacturas = new HashSet<FctFacturas>();
        }

        public decimal NroAutorizacion { get; set; }
        public int IdAsignacion { get; set; }
        public int IdCaracteristicaEspecial { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaLimiteEmision { get; set; }
        public string LeyendaAsignada { get; set; }
        public string NroTramite { get; set; }
        public string Llave { get; set; }

        public FctAsignacionesSistema IdAsignacionNavigation { get; set; }
        public ICollection<FctFacturas> FctFacturas { get; set; }
    }
}

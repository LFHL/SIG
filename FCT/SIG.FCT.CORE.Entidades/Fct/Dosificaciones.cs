using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class Dosificaciones
    {
        public Dosificaciones()
        {
            FctFacturas = new HashSet<Facturas>();
        }

        public decimal NroAutorizacion { get; set; }
        public int IdAsignacion { get; set; }
        public int IdCaracteristicaEspecial { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaLimiteEmision { get; set; }
        public string LeyendaAsignada { get; set; }
        public string NroTramite { get; set; }
        public string Llave { get; set; }

        public AsignacionesSistema IdAsignacionNavigation { get; set; }
        public ICollection<Facturas> FctFacturas { get; set; }
    }
}

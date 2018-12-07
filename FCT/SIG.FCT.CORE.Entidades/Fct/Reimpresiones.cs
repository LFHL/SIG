using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class Reimpresiones
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Motivo { get; set; }

        public Facturas IdFacturaNavigation { get; set; }
    }
}

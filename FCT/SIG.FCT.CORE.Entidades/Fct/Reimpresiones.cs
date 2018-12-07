using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctReimpresiones
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string Motivo { get; set; }

        public FctFacturas IdFacturaNavigation { get; set; }
    }
}

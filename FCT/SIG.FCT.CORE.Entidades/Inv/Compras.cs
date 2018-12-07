using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvCompras
    {
        public InvCompras()
        {
            InvDetalleCompras = new HashSet<InvDetalleCompras>();
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string IdMoneda { get; set; }
        public double TipoCambio { get; set; }

        public ICollection<InvDetalleCompras> InvDetalleCompras { get; set; }
    }
}

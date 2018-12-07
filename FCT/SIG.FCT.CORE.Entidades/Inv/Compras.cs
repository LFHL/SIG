using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class Compras
    {
        public Compras()
        {
            InvDetalleCompras = new HashSet<DetalleCompras>();
        }

        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string IdProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public string IdMoneda { get; set; }
        public double TipoCambio { get; set; }

        public ICollection<DetalleCompras> InvDetalleCompras { get; set; }
    }
}

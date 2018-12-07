using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class DetalleVentas
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public short Cantidad { get; set; }
        public short PctDescuento { get; set; }
        public decimal? MontoTotal { get; set; }
        public string Comentarios { get; set; }

        public Productos IdProductoNavigation { get; set; }
        public Ventas IdVentaNavigation { get; set; }
    }
}

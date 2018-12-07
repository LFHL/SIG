using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvDetalleVentas
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public short Cantidad { get; set; }
        public short PctDescuento { get; set; }
        public decimal? MontoTotal { get; set; }
        public string Comentarios { get; set; }

        public InvProductos IdProductoNavigation { get; set; }
        public InvVentas IdVentaNavigation { get; set; }
    }
}

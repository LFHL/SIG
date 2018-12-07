using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvDetalleCompras
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public short Cantidad { get; set; }
        public decimal CostoUnidad { get; set; }
        public decimal? Total { get; set; }

        public InvCompras IdCompraNavigation { get; set; }
        public InvProductos IdProductoNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class DetalleCompras
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public short Cantidad { get; set; }
        public decimal CostoUnidad { get; set; }
        public decimal? Total { get; set; }

        public Compras IdCompraNavigation { get; set; }
        public Productos IdProductoNavigation { get; set; }
    }
}

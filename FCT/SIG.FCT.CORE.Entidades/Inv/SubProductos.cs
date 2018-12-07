using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class SubProductos
    {
        public int IdProducto { get; set; }
        public int IdSubProducto { get; set; }

        public Productos IdProductoNavigation { get; set; }
        public Productos IdSubProductoNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvSubProductos
    {
        public int IdProducto { get; set; }
        public int IdSubProducto { get; set; }

        public InvProductos IdProductoNavigation { get; set; }
        public InvProductos IdSubProductoNavigation { get; set; }
    }
}

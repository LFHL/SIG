using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class ParCategoriasProducto
    {
        public ParCategoriasProducto()
        {
            InvProductos = new HashSet<InvProductos>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<InvProductos> InvProductos { get; set; }
    }
}

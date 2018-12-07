using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.CORE.Entidades.Par
{
    public partial class CategoriasProducto
    {
        public CategoriasProducto()
        {
            InvProductos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Productos> InvProductos { get; set; }
    }
}

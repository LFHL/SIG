using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvProductos
    {
        public InvProductos()
        {
            InvDetalleCompras = new HashSet<InvDetalleCompras>();
            InvDetalleVentas = new HashSet<InvDetalleVentas>();
            InvSubProductosIdProductoNavigation = new HashSet<InvSubProductos>();
            InvSubProductosIdSubProductoNavigation = new HashSet<InvSubProductos>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
        public int IdTipoUnidad { get; set; }
        public bool? EsParaVenta { get; set; }

        public ParCategoriasProducto IdCategoriaNavigation { get; set; }
        public ICollection<InvDetalleCompras> InvDetalleCompras { get; set; }
        public ICollection<InvDetalleVentas> InvDetalleVentas { get; set; }
        public ICollection<InvSubProductos> InvSubProductosIdProductoNavigation { get; set; }
        public ICollection<InvSubProductos> InvSubProductosIdSubProductoNavigation { get; set; }
    }
}

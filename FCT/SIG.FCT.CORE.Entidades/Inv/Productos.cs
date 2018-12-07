using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class Productos
    {
        public Productos()
        {
            InvDetalleCompras = new HashSet<DetalleCompras>();
            InvDetalleVentas = new HashSet<DetalleVentas>();
            InvSubProductosIdProductoNavigation = new HashSet<SubProductos>();
            InvSubProductosIdSubProductoNavigation = new HashSet<SubProductos>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int IdCategoria { get; set; }
        public int IdTipoUnidad { get; set; }
        public bool? EsParaVenta { get; set; }

        public CategoriasProducto IdCategoriaNavigation { get; set; }
        public ICollection<DetalleCompras> InvDetalleCompras { get; set; }
        public ICollection<DetalleVentas> InvDetalleVentas { get; set; }
        public ICollection<SubProductos> InvSubProductosIdProductoNavigation { get; set; }
        public ICollection<SubProductos> InvSubProductosIdSubProductoNavigation { get; set; }
    }
}

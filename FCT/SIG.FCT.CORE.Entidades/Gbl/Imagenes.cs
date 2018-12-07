using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class GblImagenes
    {
        public GblImagenes()
        {
            FctSucursales = new HashSet<FctSucursales>();
            GblEmpresas = new HashSet<GblEmpresas>();
        }

        public int Id { get; set; }
        public int? IdType { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }

        public ICollection<FctSucursales> FctSucursales { get; set; }
        public ICollection<GblEmpresas> GblEmpresas { get; set; }
    }
}

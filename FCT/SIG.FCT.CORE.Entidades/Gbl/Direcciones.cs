using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class GblDirecciones
    {
        public GblDirecciones()
        {
            FctSucursales = new HashSet<FctSucursales>();
            GblEmpresas = new HashSet<GblEmpresas>();
            GblPersonas = new HashSet<GblPersonas>();
        }

        public int Id { get; set; }
        public string Departamento { get; set; }
        public string Lugar { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string DireccionDescriptiva { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }

        public ICollection<FctSucursales> FctSucursales { get; set; }
        public ICollection<GblEmpresas> GblEmpresas { get; set; }
        public ICollection<GblPersonas> GblPersonas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.CORE.Entidades.Gbl
{
    public partial class Direcciones
    {
        public Direcciones()
        {
            FctSucursales = new HashSet<Sucursales>();
            GblEmpresas = new HashSet<Empresas>();
            GblPersonas = new HashSet<Personas>();
        }

        public int Id { get; set; }
        public string Departamento { get; set; }
        public string Lugar { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string DireccionDescriptiva { get; set; }
        public int? PosX { get; set; }
        public int? PosY { get; set; }

        public ICollection<Sucursales> FctSucursales { get; set; }
        public ICollection<Empresas> GblEmpresas { get; set; }
        public ICollection<Personas> GblPersonas { get; set; }
    }
}

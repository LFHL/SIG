using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.CORE.Entidades.Gbl
{
    public partial class Imagenes
    {
        public Imagenes()
        {
            FctSucursales = new HashSet<Sucursales>();
            GblEmpresas = new HashSet<Empresas>();
        }

        public int Id { get; set; }
        public int? IdType { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }

        public ICollection<Sucursales> FctSucursales { get; set; }
        public ICollection<Empresas> GblEmpresas { get; set; }
    }
}

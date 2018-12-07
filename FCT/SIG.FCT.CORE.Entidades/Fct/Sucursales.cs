using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class Sucursales
    {
        public Sucursales()
        {
            FctAsignacionesSistema = new HashSet<AsignacionesSistema>();
        }

        public int Numero { get; set; }
        public string NombreComercial { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdLogo { get; set; }
        public string Telefonos { get; set; }
        public string Email { get; set; }

        public Direcciones IdDireccionNavigation { get; set; }
        public Imagenes IdLogoNavigation { get; set; }
        public ICollection<AsignacionesSistema> FctAsignacionesSistema { get; set; }
    }
}

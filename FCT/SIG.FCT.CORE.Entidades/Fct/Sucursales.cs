using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctSucursales
    {
        public FctSucursales()
        {
            FctAsignacionesSistema = new HashSet<FctAsignacionesSistema>();
        }

        public int Numero { get; set; }
        public string NombreComercial { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdLogo { get; set; }
        public string Telefonos { get; set; }
        public string Email { get; set; }

        public GblDirecciones IdDireccionNavigation { get; set; }
        public GblImagenes IdLogoNavigation { get; set; }
        public ICollection<FctAsignacionesSistema> FctAsignacionesSistema { get; set; }
    }
}

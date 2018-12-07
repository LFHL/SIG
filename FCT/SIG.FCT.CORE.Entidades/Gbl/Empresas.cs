using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Gbl
{
    public partial class Empresas
    {
        public decimal Nit { get; set; }
        public int? IdTipoSociedad { get; set; }
        public string RazonSocial { get; set; }
        public decimal? MatriculaComercio { get; set; }
        public int? IdSitioWeb { get; set; }
        public int? IdTelefonoPrincipal { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdLogo { get; set; }

        public Direcciones IdDireccionNavigation { get; set; }
        public Imagenes IdLogoNavigation { get; set; }
        public PropiedadesContacto IdSitioWebNavigation { get; set; }
        public PropiedadesContacto IdTelefonoPrincipalNavigation { get; set; }
    }
}

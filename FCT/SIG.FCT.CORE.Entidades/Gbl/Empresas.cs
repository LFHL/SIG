using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class GblEmpresas
    {
        public decimal Nit { get; set; }
        public int? IdTipoSociedad { get; set; }
        public string RazonSocial { get; set; }
        public decimal? MatriculaComercio { get; set; }
        public int? IdSitioWeb { get; set; }
        public int? IdTelefonoPrincipal { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdLogo { get; set; }

        public GblDirecciones IdDireccionNavigation { get; set; }
        public GblImagenes IdLogoNavigation { get; set; }
        public GblPropiedadesContacto IdSitioWebNavigation { get; set; }
        public GblPropiedadesContacto IdTelefonoPrincipalNavigation { get; set; }
    }
}

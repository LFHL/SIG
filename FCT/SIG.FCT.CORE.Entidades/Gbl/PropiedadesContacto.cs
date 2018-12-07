using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class GblPropiedadesContacto
    {
        public GblPropiedadesContacto()
        {
            GblEmpresasIdSitioWebNavigation = new HashSet<GblEmpresas>();
            GblEmpresasIdTelefonoPrincipalNavigation = new HashSet<GblEmpresas>();
            GblPersonas = new HashSet<GblPersonas>();
        }

        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Valor { get; set; }

        public ParGenerales IdTipoNavigation { get; set; }
        public ICollection<GblEmpresas> GblEmpresasIdSitioWebNavigation { get; set; }
        public ICollection<GblEmpresas> GblEmpresasIdTelefonoPrincipalNavigation { get; set; }
        public ICollection<GblPersonas> GblPersonas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.CORE.Entidades.Gbl
{
    public partial class PropiedadesContacto
    {
        public PropiedadesContacto()
        {
            EmpresasIdSitioWebNavigation = new HashSet<Empresas>();
            EmpresasIdTelefonoPrincipalNavigation = new HashSet<Empresas>();
            Personas = new HashSet<Personas>();
        }

        public int Id { get; set; }
        public int IdTipo { get; set; }
        public string Valor { get; set; }

        public Generales IdTipoNavigation { get; set; }
        public ICollection<Empresas> EmpresasIdSitioWebNavigation { get; set; }
        public ICollection<Empresas> EmpresasIdTelefonoPrincipalNavigation { get; set; }
        public ICollection<Personas> Personas { get; set; }
    }
}

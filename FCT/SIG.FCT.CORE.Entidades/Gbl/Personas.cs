using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades.Gbl
{
    public partial class Personas
    {
        public int Id { get; set; }
        public string NroDocumento { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string FechaNacimiento { get; set; }
        public int? IdDireccion { get; set; }
        public int? IdTelefonoPrincipal { get; set; }
        public int? IdCorreoPrincipal { get; set; }

        public Direcciones IdDireccionNavigation { get; set; }
        public PropiedadesContacto IdTelefonoPrincipalNavigation { get; set; }
    }
}

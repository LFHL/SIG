using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Fct;
using SIG.FCT.CORE.Entidades.Gbl;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.CORE.Entidades.Par
{
    public partial class Generales
    {
        public Generales()
        {
            FctAsignacionesSistema = new HashSet<AsignacionesSistema>();
            GblPropiedadesContacto = new HashSet<PropiedadesContacto>();
            InvVentas = new HashSet<Ventas>();
            InverseIdTipoNavigation = new HashSet<Generales>();
        }

        public int Id { get; set; }
        public int? IdTipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public bool? Habilitado { get; set; }

        public Generales IdTipoNavigation { get; set; }
        public ICollection<AsignacionesSistema> FctAsignacionesSistema { get; set; }
        public ICollection<PropiedadesContacto> GblPropiedadesContacto { get; set; }
        public ICollection<Ventas> InvVentas { get; set; }
        public ICollection<Generales> InverseIdTipoNavigation { get; set; }
    }
}

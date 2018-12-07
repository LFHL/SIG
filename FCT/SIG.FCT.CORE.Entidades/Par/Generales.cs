using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class ParGenerales
    {
        public ParGenerales()
        {
            FctAsignacionesSistema = new HashSet<FctAsignacionesSistema>();
            GblPropiedadesContacto = new HashSet<GblPropiedadesContacto>();
            InvVentas = new HashSet<InvVentas>();
            InverseIdTipoNavigation = new HashSet<ParGenerales>();
        }

        public int Id { get; set; }
        public int? IdTipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public bool? Habilitado { get; set; }

        public ParGenerales IdTipoNavigation { get; set; }
        public ICollection<FctAsignacionesSistema> FctAsignacionesSistema { get; set; }
        public ICollection<GblPropiedadesContacto> GblPropiedadesContacto { get; set; }
        public ICollection<InvVentas> InvVentas { get; set; }
        public ICollection<ParGenerales> InverseIdTipoNavigation { get; set; }
    }
}

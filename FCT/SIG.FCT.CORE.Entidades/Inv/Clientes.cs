using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvClientes
    {
        public InvClientes()
        {
            InvVentas = new HashSet<InvVentas>();
        }

        public int Id { get; set; }
        public decimal Nit { get; set; }
        public string RazonSocial { get; set; }
        public int? IdTipoObjeto { get; set; }
        public decimal? IdObjeto { get; set; }

        public ParTiposObjeto IdTipoObjetoNavigation { get; set; }
        public ICollection<InvVentas> InvVentas { get; set; }
    }
}

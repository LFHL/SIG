using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class Clientes
    {
        public Clientes()
        {
            InvVentas = new HashSet<Ventas>();
        }

        public int Id { get; set; }
        public decimal Nit { get; set; }
        public string RazonSocial { get; set; }
        public int? IdTipoObjeto { get; set; }
        public decimal? IdObjeto { get; set; }

        public TiposObjeto IdTipoObjetoNavigation { get; set; }
        public ICollection<Ventas> InvVentas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.CORE.Entidades.Par
{
    public partial class TiposObjeto
    {
        public TiposObjeto()
        {
            InvClientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TablaAsociada { get; set; }

        public ICollection<Clientes> InvClientes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class ParTiposObjeto
    {
        public ParTiposObjeto()
        {
            InvClientes = new HashSet<InvClientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TablaAsociada { get; set; }

        public ICollection<InvClientes> InvClientes { get; set; }
    }
}

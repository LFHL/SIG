using System;
using System.Collections.Generic;
using System.Text;

namespace SIG.CORE.Comun.Dominio.Entidades.Base
{
    internal abstract class EntidadBase
    {
        public int Id { get; set; }

        internal Guid GuidRegistro { get; set; }
        
    }
}

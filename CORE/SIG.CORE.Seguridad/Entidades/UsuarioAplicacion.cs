using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace SIG.CORE.Seguridad.Entidades
{
    public class UsuarioAplicacion : IIdentity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string AuthenticationType { get; }
        public bool IsAuthenticated { get; }
        public string Name { get; }
    }
}

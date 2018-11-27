using System;
using System.Collections.Generic;

namespace SIG.FCT.CORE.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            Ordenes = new HashSet<Orden>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public ICollection<Orden> Ordenes { get; set; }

    }
}

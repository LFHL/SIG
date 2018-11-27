using System;

namespace SIG.FCT.CORE.Entidades
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime? FechaOrden { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public Cliente Cliente { get; set; }
    }
}

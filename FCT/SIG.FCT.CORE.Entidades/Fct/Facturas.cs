using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.CORE.Entidades.Fct
{
    public partial class Facturas
    {
        public Facturas()
        {
            FctReimpresiones = new HashSet<Reimpresiones>();
        }

        public int IdVenta { get; set; }
        public decimal NroAutorizacion { get; set; }
        public decimal Numero { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal NitCliente { get; set; }
        public string RazonSocial { get; set; }
        public decimal MontoTotal { get; set; }
        public string CodigoDeControl { get; set; }
        public int IdEstado { get; set; }
        public byte[] CodigoQr { get; set; }

        public Ventas IdVentaNavigation { get; set; }
        public Dosificaciones NroAutorizacionNavigation { get; set; }
        public ICollection<Reimpresiones> FctReimpresiones { get; set; }
    }
}

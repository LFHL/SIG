using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class FctFacturas
    {
        public FctFacturas()
        {
            FctReimpresiones = new HashSet<FctReimpresiones>();
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

        public InvVentas IdVentaNavigation { get; set; }
        public FctDosificaciones NroAutorizacionNavigation { get; set; }
        public ICollection<FctReimpresiones> FctReimpresiones { get; set; }
    }
}

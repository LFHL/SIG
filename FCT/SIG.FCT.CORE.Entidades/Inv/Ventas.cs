using System;
using System.Collections.Generic;

namespace web.Modelos
{
    public partial class InvVentas
    {
        public InvVentas()
        {
            InvDetalleVentas = new HashSet<InvDetalleVentas>();
        }

        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdMoneda { get; set; }
        public double TipoCambio { get; set; }

        public InvClientes IdClienteNavigation { get; set; }
        public ParGenerales IdMonedaNavigation { get; set; }
        public FctFacturas FctFacturas { get; set; }
        public ICollection<InvDetalleVentas> InvDetalleVentas { get; set; }
    }
}

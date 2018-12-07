using System;
using System.Collections.Generic;
using SIG.FCT.CORE.Entidades.Fct;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.CORE.Entidades.Inv
{
    public partial class Ventas
    {
        public Ventas()
        {
            InvDetalleVentas = new HashSet<DetalleVentas>();
        }

        public int Id { get; set; }
        public int IdVendedor { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdMoneda { get; set; }
        public double TipoCambio { get; set; }

        public Clientes IdClienteNavigation { get; set; }
        public Generales IdMonedaNavigation { get; set; }
        public Facturas FctFacturas { get; set; }
        public ICollection<DetalleVentas> InvDetalleVentas { get; set; }
    }
}

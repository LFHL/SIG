using System;
using System.Linq;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Persistencia.EF.Modelo
{
    public class ContextoFCTInitializer
    {
        public static void Initialize( ContextoFCT context )
        {
            var initializer = new ContextoFCTInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything( ContextoFCT context )
        {
            context.Database.EnsureCreated();

            if (context.Clientes.Any())
            {
                return; // Db has been seeded
            }

            PoblarClientes(context);

            PoblarOrdenes(context);


        }

        private void PoblarOrdenes( ContextoFCT context )
        {
            var ordenes = new[]
{
                new Orden { FechaEntrega=DateTime.Now.AddMonths(2), FechaOrden= DateTime.Now.AddDays(-1), Cliente = new Cliente(){Id=0} },
                new Orden { FechaEntrega=DateTime.Now.AddMonths(1), FechaOrden= DateTime.Now.AddMonths(-1), Cliente = new Cliente(){Id=0} },
                new Orden { FechaEntrega=DateTime.Now.AddMonths(3), FechaOrden= DateTime.Now.AddDays(-7), Cliente = new Cliente(){Id=1} },
            };

            context.Ordenes.AddRange(ordenes);

            context.SaveChanges();
        }

        private void PoblarClientes( ContextoFCT context )
        {
            var clientes = new[]
{
                new Cliente { Direccion = "Obere Str. 57", Nombres = "Maria ", Apellidos = "Anders" },
                new Cliente { Direccion = "Avda. de la Constitución 2222", Nombres = "Ana", Apellidos = "Trujillo"},
                new Cliente { Direccion = "Mataderos  2312", Nombres = "Antonio", Apellidos = "Moreno"},
            };

            context.Clientes.AddRange(clientes);

            context.SaveChanges();
        }

    }
}


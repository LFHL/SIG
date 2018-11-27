using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Persistencia.EF.Modelo
{
    public class InicializadorDeContexto
    {
        private readonly Dictionary<int, Cliente> Clientes = new Dictionary<int, Cliente>();
        private readonly Dictionary<int, Orden> Ordenes = new Dictionary<int, Orden>();

        public static void Initialize( ContextoEnMemoria context )
        {
            var initializer = new InicializadorDeContexto();
            initializer.SeedEverything(context);
        }

        public void SeedEverything( ContextoEnMemoria context )
        {
            context.Database.EnsureCreated();

            if (context.Clientes.Any())
            {
                return; // Db has been seeded
            }

            PoblarClientes(context);

            PoblarOrdenes(context);


        }

        private void PoblarOrdenes( ContextoEnMemoria context )
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

        private void PoblarClientes( ContextoEnMemoria context )
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


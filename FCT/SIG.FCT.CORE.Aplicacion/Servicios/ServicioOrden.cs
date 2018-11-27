using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Servicios
{
    public class ServicioOrden : IServicioOrden
    {
        readonly IUnidadDeTrabajo db;
        readonly IRepositorio<Cliente> manejadorClientes;
        readonly IRepositorio<Orden> manejadorOrdenes;


        public ServicioOrden( IUnidadDeTrabajo unidadDeTrabajo )
        {
            db = unidadDeTrabajo;
            manejadorOrdenes = db.Ordenes;
            manejadorClientes = db.Clientes;
        }

        public Orden Nuevo()
        {
            return new Orden();
        }

        public Orden Actualizar( Orden ordenActualizada )
        {
            throw new NotImplementedException();
        }

        public Orden BuscarPorId( int id )
        {
            throw new NotImplementedException();
        }

        public Orden Crear( Orden orden )
        {
            if (orden.Cliente == null || orden.Cliente.Id <= 0)
                throw new InvalidDataException("To create Order you need a Customer");

            if (manejadorClientes.BuscarPorId(orden.Cliente.Id) == null)
                throw new InvalidDataException("Customer Not found");

            if (orden.FechaOrden == null)
                throw new InvalidDataException("Order needs a Order Date");

            manejadorOrdenes.Insertar(orden);
            db.Guardar();
            return orden;
        }

        public Orden Eliminar( int id )
        {
            Orden orden = manejadorOrdenes.BuscarPorId(id);
            manejadorOrdenes.Eliminar(orden);
            return orden;
        }

        public List<Orden> ListarTodos()
        {
            return manejadorOrdenes.Buscar().ToList();
        }

      
    }
}

using System.Collections.Generic;
using System.Linq;
using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Servicios
{
    public class ServicioCliente : IServicioCliente
    {
        IUnidadDeTrabajo db;
        IRepositorioCliente manejadorClientes;


        public ServicioCliente( IUnidadDeTrabajo unidadDeTrabajo)
        {
            db = unidadDeTrabajo;
            manejadorClientes = db.Clientes;
        }


        public Cliente Nuevo( string nombres, string apellidos, string direccion )
        {
            return new Cliente()
            {
                Nombres = nombres,
                Apellidos = apellidos,
                Direccion = direccion
            };
        }

        public Cliente Actualizar( Cliente clienteActualizado )
        {
            var customer = BuscarPorId(clienteActualizado.Id);
            customer.Nombres = clienteActualizado.Nombres;
            customer.Apellidos = clienteActualizado.Apellidos;
            customer.Direccion = clienteActualizado.Direccion;
            db.Guardar();
            return customer;
        }

        public Cliente BuscarPorId( int id )
        {
            return manejadorClientes.BuscarPorId(id);
        }

        public Cliente BuscarPorIdIncluirOrdenes( int id )
        {
            var customer = manejadorClientes.BuscarPorId(id);
            customer.Ordenes = db.Ordenes.Buscar(order => order.Cliente.Id == customer.Id)
                .ToList();
            return customer;
        }

        public Cliente Crear( Cliente cliente )
        {
            manejadorClientes.Insertar(cliente);
            db.Guardar();
            return cliente;
        }

        public Cliente Eliminar( int id )
        {
            Cliente cliente = manejadorClientes.BuscarPorId(id);
            manejadorClientes.Eliminar(cliente);
            return cliente;
        }

        public List<Cliente> ListarTodos()
        {
            return manejadorClientes.Buscar().ToList();
        }

        public List<Cliente> ListarTodosPorNombre( string nombre )
        {
            return manejadorClientes.Buscar(cli => cli.Nombres.Contains(nombre) || cli.Apellidos.Contains(nombre)).ToList();
        }

     
    }
}

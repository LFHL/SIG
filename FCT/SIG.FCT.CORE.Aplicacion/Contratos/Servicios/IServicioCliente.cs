using System;
using System.Collections.Generic;
using System.Text;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Contratos.Servicios
{
    public interface IServicioCliente
    {
        //New Customer
        Cliente Nuevo( string nombres, string apellidos, string direccion );

        //Create //POST
        Cliente Crear( Cliente cliente );

        //Read //GET
        Cliente BuscarPorId( int id );
        Cliente BuscarPorIdIncluirOrdenes( int id );
        List<Cliente> ListarTodos();
        List<Cliente> ListarTodosPorNombre( string nombre );
        
        //Update //PUT
        Cliente Actualizar( Cliente clienteActualizado );

        //Delete //DELETE
        Cliente Eliminar( int id );
    }

}

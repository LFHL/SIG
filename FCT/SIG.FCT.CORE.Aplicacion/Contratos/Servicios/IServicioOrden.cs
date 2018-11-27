using System;
using System.Collections.Generic;
using System.Text;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Contratos.Servicios
{
    public interface IServicioOrden

    {
        //New Order
        Orden Nuevo();

        //Create //POST
        Orden Crear( Orden orden );

        //Read //GET
        Orden BuscarPorId( int id );
        List<Orden> ListarTodos();

        //Update //PUT
        Orden Actualizar( Orden ordenActualizada );

        //Delete //DELETE
        Orden Eliminar( int id );
    }
}
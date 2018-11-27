using System.Collections.Generic;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Contratos.Repositorio
{
    public interface IRepositorioCliente : IRepositorio<Cliente>
    {
        IEnumerable<Cliente> Listar( int count );
        IEnumerable<Cliente> ListarPaginado( int index, int size );
    }
}

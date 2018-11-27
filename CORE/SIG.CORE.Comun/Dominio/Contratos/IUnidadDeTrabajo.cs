using System.Threading;
using System.Threading.Tasks;

namespace SIG.CORE.Comun.Dominio.Contratos
{
    public interface IUnidadDeTrabajo
    {
        IRepositorio<TRepo> Repositorio<TRepo>() where TRepo : class;
        // other methods
        int Guardar();
        Task<int> GuardarAsync( CancellationToken cancellationToken = default(CancellationToken) );
    }
}

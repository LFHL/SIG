using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Base;
using SIG.FCT.Persistencia.EF.Modelo;

namespace SIG.FCT.Persistencia.EF.Repositorios
{
    class RepositorioOrden : Repositorio<Orden>
    {
        public ContextoEnMemoria ContextoDelRepositorio
        {
            get { return Contexto as ContextoEnMemoria; }
        }

        public RepositorioOrden( ContextoEnMemoria contexto ) : base(contexto)
        {
        }
    }
}

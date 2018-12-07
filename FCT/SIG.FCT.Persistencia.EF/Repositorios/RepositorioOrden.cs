using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Base;
using SIG.FCT.Persistencia.EF.Modelo;

namespace SIG.FCT.Persistencia.EF.Repositorios
{
    class RepositorioOrden : Repositorio<Orden>
    {
        public ContextoFCT ContextoDelRepositorio
        {
            get { return Contexto as ContextoFCT; }
        }

        public RepositorioOrden( ContextoFCT contexto ) : base(contexto)
        {
        }
    }
}

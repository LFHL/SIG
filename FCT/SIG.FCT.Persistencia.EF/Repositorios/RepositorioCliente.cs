using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Base;
using SIG.FCT.Persistencia.EF.Modelo;

namespace SIG.FCT.Persistencia.EF.Repositorios
{
    public class RepositorioCliente : Repositorio<Cliente>, IRepositorioCliente
    {
        public ContextoEnMemoria ContextoDelRepositorio
        {
            get { return Contexto as ContextoEnMemoria; }
        }

        public RepositorioCliente( ContextoEnMemoria contexto ) : base(contexto)
        {
        }

        public IEnumerable<Cliente> Listar( int count )
        {
            using (var contexto = ContextoDelRepositorio)
            {
                return contexto.Clientes
                    .OrderByDescending(a => a.Apellidos)
                    .Take(count)
                    .ToList();
            }
        }

        public IEnumerable<Cliente> ListarPaginado( int index, int size = 10 )
        {
            using (var contexto = ContextoDelRepositorio)
            {
                return contexto.Clientes
                    .Include(x => x.Ordenes.Select(orden => orden.Cliente))
                    .Skip((index - 1) * size)
                    .Take(size)
                    .ToList();
            }
        }
    }
}

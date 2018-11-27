using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIG.CORE.Comun.Dominio.Contratos;
using SIG.CORE.Persistencia.EF.Modelo;

namespace SIG.CORE.Persistencia.EF.Base
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo, IDisposable
    {
        private readonly ContextoSeguridad _contexto;

        public IRepositorio<TRepo> Repositorio<TRepo>() where TRepo : class
        {
            return new Repositorio<TRepo>(_contexto); ;
        }

        public UnidadDeTrabajo( )
        {
            
            var options = new DbContextOptionsBuilder<ContextoSeguridad>()
                .UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SIG_SecurityDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False")
                //.UseInMemoryDatabase(databaseName: "SecurityDB")
                .Options;
            _contexto = new ContextoSeguridad(options);
        }

        public int Guardar()
        {
            return _contexto.SaveChanges();
        }

        public async Task<int> GuardarAsync( CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _contexto.SaveChangesAsync(cancellationToken);
        }

        private bool disposed = false;

        protected virtual void Dispose( bool disposing )
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
                disposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnidadDeTrabajo() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       
    }
}

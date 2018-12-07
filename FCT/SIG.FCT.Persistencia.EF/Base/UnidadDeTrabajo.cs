using System;
using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Entidades;
using SIG.FCT.Persistencia.EF.Modelo;
using SIG.FCT.Persistencia.EF.Repositorios;

namespace SIG.FCT.Persistencia.EF.Base
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly ContextoFCT _contexto;
        public IRepositorioCliente Clientes { get; }
        public IRepositorio<Orden> Ordenes { get; }

        public UnidadDeTrabajo(bool EnMemoria = false )
        {
            var factory = new AppDbContextFactory();
            _contexto = EnMemoria ? factory.CreateInMemory("FCT_Database") : factory.Create();

            Clientes = new RepositorioCliente(_contexto);
            Ordenes = new RepositorioOrden(_contexto);
        }

        public int Guardar()
        {
            return _contexto.SaveChanges();
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

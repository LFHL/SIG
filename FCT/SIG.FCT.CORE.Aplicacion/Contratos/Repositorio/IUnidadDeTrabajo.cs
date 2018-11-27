using System;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.CORE.Aplicacion.Contratos.Repositorio
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        IRepositorioCliente Clientes { get; }
        IRepositorio<Orden> Ordenes { get; }

        int Guardar();
    }
}

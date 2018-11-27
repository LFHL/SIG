namespace SIG.CORE.Comun.Dominio.Contratos
{
    public interface IUnidadDeTrabajo
    {
        IRepositorio<TRepo> Repositorio<TRepo>() where TRepo : class;
        // other methods
        int Guardar();
       
    }
}

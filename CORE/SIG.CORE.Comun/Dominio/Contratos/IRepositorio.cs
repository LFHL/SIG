using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SIG.CORE.Comun.Dominio.Contratos
{
    public interface IRepositorio<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> Buscar(
                            Expression<Func<TEntity, bool>> filter = null,
                            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                            string includeProperties = "" );

        TEntity BuscarPorId( object id );



        void Insertar( TEntity entity );
        void InsertarRango( IEnumerable<TEntity> entities );

        void Actualizar( TEntity entityToUpdate );

        void Eliminar( TEntity entity );
        void EliminarRango( IEnumerable<TEntity> entities );
        void Eliminar( object id );
    }
}

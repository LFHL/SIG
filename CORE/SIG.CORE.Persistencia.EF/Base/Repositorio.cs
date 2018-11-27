using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SIG.CORE.Comun.Dominio.Contratos;

namespace SIG.CORE.Persistencia.EF.Base
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected readonly DbContext Contexto;
        internal DbSet<TEntity> dbSet;

        public Repositorio( DbContext contexto)
        {
            Contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
            dbSet = contexto.Set<TEntity>();
        }

        #region CRUD Operations 

        #region Select 


        public virtual IEnumerable<TEntity> Buscar(
                    Expression<Func<TEntity, bool>> filter = null,
                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                    string includeProperties = "" )
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity BuscarPorId( object id )
        {
            return dbSet.Find(id);
        }
        public virtual Task<TEntity> BuscarPorIdAsync( object id, CancellationToken cancellationToken = default(CancellationToken) )
        {
            return dbSet.FindAsync(id, cancellationToken);
        }

        #endregion Select

        #region Insert 

        public virtual void Insertar( TEntity entity )
        {
            dbSet.Add(entity);
        }

        public virtual void InsertarAsync( TEntity entity, CancellationToken cancellationToken = default(CancellationToken) )
        {
            dbSet.AddAsync(entity, cancellationToken);
        }


        public virtual void InsertarRango( IEnumerable<TEntity> entities )
        {
            dbSet.AddRange(entities);
        }

        #endregion Insert

        #region Update 

        public virtual void Actualizar( TEntity entityToUpdate )
        {
            dbSet.Attach(entityToUpdate);
            Contexto.Entry(entityToUpdate).State = EntityState.Modified;
        }

        #endregion Update

        #region Delete 

        public virtual void Eliminar( TEntity entity )
        {
            if (Contexto.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public virtual void EliminarRango( IEnumerable<TEntity> entities )
        {
            dbSet.RemoveRange(entities);
        }

        public virtual void Eliminar( object id )
        {
            TEntity entityToDelete = dbSet.Find(id);
            Eliminar(entityToDelete);
        }

        #endregion Delete

        #endregion CRUD Operations 

    }
}

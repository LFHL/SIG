using System;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SIG.CORE.Comun.Dominio.Contratos
{
    public interface IRepositorioSeguridad<TEntity> where TEntity : IIdentity
    {
        Task<IdentityResult> CreateAsync( TEntity user );
        Task<IdentityResult> DeleteAsync( TEntity user );
        Task<TEntity> FindByIdAsync( Guid userId );
        Task<TEntity> FindByNameAsync( string userName );
    }
}

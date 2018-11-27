using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Seguridad.Dominio
{
    public class AlmacenRol : IRoleStore<RolAplicacion>
    {
        public Task<IdentityResult> CreateAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<RolAplicacion> FindByIdAsync( string roleId, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<RolAplicacion> FindByNameAsync( string normalizedRoleName, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedRoleNameAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleIdAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleNameAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync( RolAplicacion role, string normalizedName, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task SetRoleNameAsync( RolAplicacion role, string roleName, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync( RolAplicacion role, CancellationToken cancellationToken )
        {
            throw new NotImplementedException();
        }
    }
}

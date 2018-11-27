using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SIG.CORE.Comun.Dominio.Contratos;
using SIG.CORE.Persistencia.EF.Base;
using SIG.CORE.Persistencia.EF.Modelo;
using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Persistencia.EF.Repositorios.Seguridad
{
    class RepositorioUsuarios : Repositorio<UsuarioAplicacion>, IRepositorioSeguridad<UsuarioAplicacion>
    {
        public ContextoSeguridad ContextoDelRepositorio
        {
            get { return Contexto as ContextoSeguridad; }
        }

        public RepositorioUsuarios( ContextoSeguridad contexto ) : base(contexto)
        {
        }

        public async Task<IdentityResult> CreateAsync( UsuarioAplicacion user )
        {
            try
            {
                var x = await dbSet.AddAsync(user).ConfigureAwait(false);
                return IdentityResult.Success;
            }
            catch (Exception)
            {

                return IdentityResult.Failed(new IdentityError { Description = $"No se pudo insertar el usuario: {user.Correo}." }); ;
            }
            
        }

        public async Task<IdentityResult> DeleteAsync( UsuarioAplicacion user )
        {
            try
            {
                if (Contexto.Entry(user).State == EntityState.Detached)
                {
                    dbSet.Attach(user);
                }
                dbSet.Remove(user);
                return IdentityResult.Success;
            }
            catch (Exception)
            {

                return IdentityResult.Failed(new IdentityError { Description = $"Could not delete user {user.Correo}." });
            }
        }

        public async Task<UsuarioAplicacion> FindByIdAsync( long userId )
        {
            return await dbSet.FindAsync(userId).ConfigureAwait(false);
        }

        public async Task<UsuarioAplicacion> FindByNameAsync( string userName )
        {
            return await dbSet.FirstOrDefaultAsync(user => user.Name==userName).ConfigureAwait(false);
        }
    }
    {
    }
}

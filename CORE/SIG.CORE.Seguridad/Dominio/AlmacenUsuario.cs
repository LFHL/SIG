using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Seguridad.Dominio
{
    public class AlmacenUsuario : IUserStore<UsuarioAplicacion>
    {
        public AlmacenUsuario()
        {
        }

        /// <summary>
        /// Creates the specified <paramref name="user" /> in the user store.
        /// </summary>
        /// <param name="user">The user to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the <see cref="IdentityResult" /> of the creation operation.</returns>
        public Task<IdentityResult> CreateAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified <paramref name="user" /> from the user store.
        /// </summary>
        /// <param name="user">The user to delete.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the <see cref="IdentityResult" /> of the update operation.</returns>
        public Task<IdentityResult> DeleteAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds and returns a user, if any, who has the specified <paramref name="userId" />.
        /// </summary>
        /// <param name="userId">The user ID to search for.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Task" /> that represents the asynchronous operation, containing the user matching the specified <paramref name="userId" /> if it exists.
        /// </returns>
        public Task<UsuarioAplicacion> FindByIdAsync( string userId, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds and returns a user, if any, who has the specified normalized user name.
        /// </summary>
        /// <param name="normalizedUserName">The normalized user name to search for.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>
        /// The <see cref="Task" /> that represents the asynchronous operation, containing the user matching the specified <paramref name="normalizedUserName" /> if it exists.
        /// </returns>
        public Task<UsuarioAplicacion> FindByNameAsync( string normalizedUserName, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the normalized user name for the specified <paramref name="user" />.
        /// </summary>
        /// <param name="user">The user whose normalized name should be retrieved.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the normalized user name for the specified <paramref name="user" />.</returns>
        public Task<string> GetNormalizedUserNameAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the user identifier for the specified <paramref name="user" />.
        /// </summary>
        /// <param name="user">The user whose identifier should be retrieved.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the identifier for the specified <paramref name="user" />.</returns>
        public Task<string> GetUserIdAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the user name for the specified <paramref name="user" />.
        /// </summary>
        /// <param name="user">The user whose name should be retrieved.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the name for the specified <paramref name="user" />.</returns>
        public Task<string> GetUserNameAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the given normalized name for the specified <paramref name="user" />.
        /// </summary>
        /// <param name="user">The user whose name should be set.</param>
        /// <param name="normalizedName">The normalized name to set.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation.</returns>
        public Task SetNormalizedUserNameAsync( UsuarioAplicacion user, string normalizedName, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the given <paramref name="userName" /> for the specified <paramref name="user" />.
        /// </summary>
        /// <param name="user">The user whose name should be set.</param>
        /// <param name="userName">The user name to set.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation.</returns>
        public Task SetUserNameAsync( UsuarioAplicacion user, string userName, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the specified <paramref name="user" /> in the user store.
        /// </summary>
        /// <param name="user">The user to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken" /> used to propagate notifications that the operation should be canceled.</param>
        /// <returns>The <see cref="Task" /> that represents the asynchronous operation, containing the <see cref="IdentityResult" /> of the update operation.</returns>
        public Task<IdentityResult> UpdateAsync( UsuarioAplicacion user, CancellationToken cancellationToken = default(CancellationToken) )
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

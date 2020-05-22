// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserService.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The user service interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Services
{
    using System.Threading.Tasks;

    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// The user service interface.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets a user.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<User> GetUser(int id);
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseProvider.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Database data provider interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.Shared.Providers
{
    using System.Threading.Tasks;

    /// <summary>
    /// Database entity provider interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// The domain entity.
    /// </typeparam>
    /// <typeparam name="TId">
    /// Domain entity identifier
    /// </typeparam>
    public interface IDatabaseProvider<TEntity, in TId>
    {
        /// <summary>
        /// Gets a domain <see cref="TEntity"/> from an specific database provider.
        /// </summary>
        /// <param name="id">
        /// The entity identifier.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TEntity> GetEntityByIdAsync(TId id);
    }
}
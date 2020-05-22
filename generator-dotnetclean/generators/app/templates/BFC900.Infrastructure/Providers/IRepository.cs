// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The Repository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Infrastructure.Providers
{
    using System.Threading.Tasks;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    /// <typeparam name="TDbEntity">
    /// The database entity.
    /// </typeparam>
    public interface IRepository<TDbEntity> where TDbEntity : class
    {
        /// <summary>
        /// Gets asynchronously a <see cref="TDbEntity"/> element.
        /// </summary>
        /// <param name="identifiers">
        /// The identifiers.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TDbEntity> GetAsync(params object[] identifiers);
    }
}
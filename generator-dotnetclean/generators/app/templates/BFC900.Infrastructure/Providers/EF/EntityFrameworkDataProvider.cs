// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityFrameworkDataProvider.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The base entity framework database provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Infrastructure.Providers.EF
{
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The MSSQL data access provider using EF.
    /// </summary>
    /// <typeparam name="TDbEntity">
    /// The database entity.
    /// </typeparam>
    public abstract class EntityFrameworkDataProvider<TDbEntity> : IRepository<TDbEntity> where TDbEntity : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityFrameworkDataProvider{TDbEntity}"/> class.
        /// </summary>
        /// <param name="context">
        /// The Context.
        /// </param>
        protected EntityFrameworkDataProvider(DbContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// The Context.
        /// </summary>
        protected DbContext Context { get; }

        /// <inheritdoc />
        public async Task<TDbEntity> GetAsync(params object[] identifiers)
        {
            return await this.Context.Set<TDbEntity>().FindAsync(identifiers);
        }
    }
}
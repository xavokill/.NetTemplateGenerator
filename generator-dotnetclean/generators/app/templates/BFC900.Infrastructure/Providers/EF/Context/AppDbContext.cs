// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDbContext.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The app db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Infrastructure.Providers.EF.Context
{
    using <%= solution %>.Infrastructure.Providers.EF.Entities;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The app db context.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        public virtual DbSet<SUser> Users { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Defines the IUnitOfWork type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Infrastructure.Providers
{
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// The UnitOfWork interface.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Asynchronously completes changes in current context.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<int> CompleteAsync();
    }
}
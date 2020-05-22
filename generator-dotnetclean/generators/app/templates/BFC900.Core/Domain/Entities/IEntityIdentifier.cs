// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntityIdentifier.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Primary domain entity identifier interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Domain.Entities
{
    /// <summary>
    /// Primary domain entity identifier interface.
    /// </summary>
    /// <typeparam name="TId">
    /// Domain entity identifier.
    /// </typeparam>
    public interface IEntityIdentifier<TId>
    {
        /// <summary>
        /// Gets or sets the entity's identifier.
        /// </summary>
        TId Id { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserDataProvider.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   User data provider interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Providers
{
    using <%= solution %>.Core.Application.Shared.Providers;
    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// User data base provider interface.
    /// </summary>
    public interface IUserDataProvider : IDatabaseProvider<User, int>
    {
    }
}
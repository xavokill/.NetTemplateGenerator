// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserServiceProvider.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   User service provider interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Providers
{
    using <%= solution %>.Core.Application.Shared.Providers;

    /// <summary>
    /// User service provider interface.
    /// </summary>
    public interface IUserServiceProvider : IRestServiceProvider
    {
    }
}
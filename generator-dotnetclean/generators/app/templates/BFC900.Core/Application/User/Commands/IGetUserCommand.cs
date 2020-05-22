// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGetUserCommand.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Defines the IGetUserCommand type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Commands
{
    using <%= solution %>.Core.Application.Shared.Commands;
    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// The GetUserCommand interface.
    /// </summary>
    public interface IGetUserCommand : IExecutor<User, int>
    {
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserService.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The <see cref="IUserService" /> implementation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Services
{
    using System.Threading.Tasks;

    using <%= solution %>.Core.Application.User.Commands;
    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// The <see cref="IUserService"/> implementation.
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// The get user command.
        /// </summary>
        private readonly IGetUserCommand getUserCommand;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="getUserCommand">
        /// The get User Command.
        /// </param>
        public UserService(IGetUserCommand getUserCommand)
        {
            this.getUserCommand = getUserCommand;
        }

        /// <inheritdoc />
        public async Task<User> GetUser(int id)
        {
            await this.getUserCommand.Execute(id);
            return await Task.FromResult(this.getUserCommand.Result);
        }
    }
}
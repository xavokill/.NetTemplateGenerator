// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUserFromDbCommand.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Gets a user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Commands
{
    using System.Threading.Tasks;

    using <%= solution %>.Core.Application.Shared.Commands;
    using <%= solution %>.Core.Application.User.Providers;
    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// Gets a user form a data base provider.
    /// </summary>
    public class GetUserFromDbCommand : BaseCommand<User, int>, IGetUserCommand
    {
        /// <summary>
        /// The user data provider.
        /// </summary>
        private readonly IUserDataProvider dataProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserFromDbCommand"/> class.
        /// </summary>
        /// <param name="dataProvider">
        /// The data provider.
        /// </param>
        public GetUserFromDbCommand(IUserDataProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }
        
        /// <inheritdoc />
        public override async Task Execute(int parameter)
        {
            var result = await this.dataProvider.GetEntityByIdAsync(parameter);
            this.SetResult(result);
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUserFromServiceCommand.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Gets a user form a external service provider.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.User.Commands
{
    using System.Threading.Tasks;

    using <%= solution %>.Core.Application.Shared.Commands;
    using <%= solution %>.Core.Application.User.Providers;
    using <%= solution %>.Core.Domain.Entities;

    /// <summary>
    /// Gets a user form a external service provider.
    /// </summary>
    public class GetUserFromServiceCommand : BaseCommand<User, int>, IGetUserCommand
    {
        /// <summary>
        /// The base server url.
        /// </summary>
        private const string Server = "localhost";

        /// <summary>
        /// The user data provider.
        /// </summary>
        private readonly IUserServiceProvider dataProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserFromDbCommand"/> class.
        /// </summary>
        /// <param name="dataProvider">
        /// The data provider.
        /// </param>
        public GetUserFromServiceCommand(IUserServiceProvider dataProvider)
        {
            this.dataProvider = dataProvider;
        }

        /// <inheritdoc />
        public override async Task Execute(int parameter)
        {
            var url = $"http://{Server}/Users/GetUserById?Id={parameter}";
            var result = await this.dataProvider.DoGetAsync<User>(url);
            this.SetResult(result);
        }
    }
}
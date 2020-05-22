// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRestServiceProvider.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The RestServiceProvider interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.Shared.Providers
{
    using System.Threading.Tasks;

    /// <summary>
    /// The RestServiceProvider interface.
    /// </summary>
    public interface IRestServiceProvider
    {
        /// <summary>
        /// Performs a asynchronously HTTP GET operation.
        /// </summary>
        /// <typeparam name="TResult">
        /// Specific result type.
        /// </typeparam>
        /// <param name="url">
        /// The endpoint url.
        /// </param>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        Task<TResult> DoGetAsync<TResult>(string url);
    }
}
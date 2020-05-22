// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IExecutor.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Custom 'ICommand' interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.Shared.Commands
{
    using System.Threading.Tasks;

    /// <summary>
    /// Custom 'ICommand' interface.
    /// </summary>
    /// <typeparam name="TResult">
    /// The execution result type.
    /// </typeparam>
    /// <typeparam name="TParameter">
    /// The parameter type.
    /// </typeparam>
    public interface IExecutor<out TResult, in TParameter>
    {
        /// <summary>
        /// Gets the execution result.
        /// </summary>
        TResult Result { get; }

        /// <summary>
        /// Executes a parametrized action request asynchronously.
        /// </summary>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task Execute(TParameter parameter);
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseCommand.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Base executor implementation.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Application.Shared.Commands
{
    using System.Threading.Tasks;

    /// <summary>
    /// Base executor implementation.
    /// </summary>
    /// <typeparam name="TResult">
    /// The execution result type.
    /// </typeparam>
    /// <typeparam name="TParameter">
    /// The parameter type.
    /// </typeparam>
    public abstract class BaseCommand<TResult, TParameter> : IExecutor<TResult, TParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCommand{TResult,TParameter}"/> class.
        /// </summary>
        protected BaseCommand()
        {
            this.Result = default(TResult);
        }
        
        /// <inheritdoc />
        public TResult Result { get; private set; }

        /// <inheritdoc />
        public virtual async Task Execute(TParameter parameter)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// Sets the execution result.
        /// </summary>
        /// <param name="result">
        /// The result.
        /// </param>
        protected void SetResult(TResult result)
        {
            this.Result = result;
        }
    }
}
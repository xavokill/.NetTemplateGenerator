// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainLayerException.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Defines the DomainLayerException type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Domain.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    /// <inheritdoc />
    /// <summary>
    /// Represent a custom exception in the application.
    /// </summary>
    [Serializable]
    public class DomainLayerException : Exception
    {
        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLayerException" /> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        protected DomainLayerException(string message) : base(message)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLayerException" /> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="errors">
        /// The errors.
        /// </param>
        protected DomainLayerException(string message, IEnumerable<string> errors) : base(message)
        {
            this.CustomErrors = errors;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLayerException" /> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="innerException">
        /// The inner exception.
        /// </param>
        protected DomainLayerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLayerException" /> class.
        /// </summary>
        /// <param name="info">
        /// The info.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        protected DomainLayerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.CustomErrors = (IEnumerable<string>)info.GetValue(nameof(this.CustomErrors), typeof(IEnumerable<string>));
        }
        #endregion 

        /// <summary>
        /// Gets the custom errors.
        /// </summary>
        public IEnumerable<string> CustomErrors { get; }

        /// <inheritdoc />
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info), "parameter cannot be null");
            }

            info.AddValue("CustomErrors", this.CustomErrors, typeof(IEnumerable<string>));

            base.GetObjectData(info, context);
        }
    }
}
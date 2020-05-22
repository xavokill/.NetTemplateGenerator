// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityValidationException.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   The entity validation exception.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Domain.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The entity validation exception.
    /// </summary>
    [Serializable]
    public class EntityValidationException : DomainLayerException
    {
        /// <summary>
        /// The custom message exception.
        /// </summary>
        private const string CustomMessageException = "Domain-Entity has some incorrects members.";

        /// <inheritdoc />>
        public EntityValidationException() : base(CustomMessageException)
        {
        }

        /// <inheritdoc />>
        public EntityValidationException(string message) : base(message)
        {
        }

        /// <inheritdoc />>
        public EntityValidationException(IEnumerable<string> errors) : base(CustomMessageException, errors)
        {
        }

        /// <inheritdoc />>
        public EntityValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <inheritdoc />
        public EntityValidationException(Exception innerException) : base(CustomMessageException, innerException)
        {
        }

        /// <inheritdoc />
        protected EntityValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
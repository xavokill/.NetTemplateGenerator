// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEntity.cs" company="Xavokill/.NetCleanArchitecture GitHub Repository(https://github.com/xavokill/.NetCleanArchitecture/).">
//   MIT Licence. Copyright (c) 2020 Xavier Hernández Reyes
// </copyright>
// <summary>
//   Defines the base logic for all domain entities.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace <%= solution %>.Core.Domain.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using <%= solution %>.Core.Domain.Exceptions;

    /// <summary>
    /// Defines the base logic for all domain entities.
    /// </summary>
    /// <typeparam name="TId">
    /// Domain entity identifier.
    /// </typeparam>
    public abstract class BaseEntity<TId> : IEntityIdentifier<TId>
    {
        /// <inheritdoc />
        [Required]
        public TId Id { get; set; }

        /// <summary>
        /// Validates the entity.
        /// </summary>
        /// <exception cref="EntityValidationException">
        /// Thrown when type inherits from <see cref="BaseEntity"/> and has some invalid properties.
        /// </exception>
        public void Validate()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
            {
                throw new EntityValidationException(results.Select(r => r.ErrorMessage));
            }
        }
    }
}
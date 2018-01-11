// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the EntityValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;
    using FluentValidation.Results;

    /// <summary>
    /// The entity validator.
    /// </summary>
    /// <typeparam name="T"> the type entity to validate 
    /// </typeparam>
    internal class EntityValidator<T> : AbstractValidator<T>
    {
        /// <summary>
        /// The validate entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="ValidationResult"/>.
        /// </returns>
        public ValidationResult ValidateEntity(T entity)
        {
            return this.Validate(entity);
        }
    }
}

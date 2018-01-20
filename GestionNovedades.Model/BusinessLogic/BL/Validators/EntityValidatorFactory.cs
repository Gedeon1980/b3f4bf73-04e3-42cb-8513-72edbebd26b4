// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityValidatorFactory.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the EntityValidatorFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The entity validator factory.
    /// </summary>
    internal static class EntityValidatorFactory
    {
        /// <summary>
        /// The get validator.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <typeparam name="T"> entity type to validate
        /// </typeparam>
        /// <returns>
        /// The <see cref="EntityValidator{T}"/>.
        /// </returns>
        public static EntityValidator<T> GetValidator<T>(T entity)
        {
            if (entity.GetType() == typeof(Role))
            {
                return new RoleValidator() as EntityValidator<T>;
            }

            return new EntityValidator<T>();
        }
    }
}

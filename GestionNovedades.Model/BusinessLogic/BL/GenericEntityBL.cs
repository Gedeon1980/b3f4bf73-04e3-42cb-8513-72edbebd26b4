// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GenericEntityBL.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the GenericEntityBL type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL
{
    using System.Collections.Generic;
    using System.Linq;

    using GestionNovedades.Model.BusinessLogic.BL.Validators;
    using GestionNovedades.Model.ResourceAccess.DAL;
    using GestionNovedades.Model.Util;

    /// <summary>
    /// The generic entity business logic.
    /// </summary>
    /// <typeparam name="T">
    /// the entity type 
    /// </typeparam>
    internal class GenericEntityBl<T> where T : class
    {
        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Response{T}"/>.
        /// </returns>
        public Response<T> Insert(T entity)
        {
            var validationResult = EntityValidatorFactory.GetValidator(entity).Validate(entity);

            if (!validationResult.IsValid)
            {
                return new Response<T>()
                {
                    OperationResult = entity,
                    IsValid = validationResult.IsValid,
                    Error = validationResult.Errors.Select(p => p.ErrorMessage).ToList()
                };
            }

            using (GiUnitOfWork unitOfWork = new GiUnitOfWork())
            {
                unitOfWork.GetRepository<T>().Insert(entity);
                unitOfWork.Save();

                return new Response<T>()
                {
                    OperationResult = entity,
                    IsValid = true,
                    Error = new List<string>()
                };
            }
        }
    }
}

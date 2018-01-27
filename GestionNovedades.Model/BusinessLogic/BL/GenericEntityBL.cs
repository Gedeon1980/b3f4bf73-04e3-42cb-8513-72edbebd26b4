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
    using System.Runtime.InteropServices.WindowsRuntime;

    using GestionNovedades.Model.BusinessLogic.BL.Validators;
    using GestionNovedades.Model.ResourceAccess.DAL;
    using GestionNovedades.Model.Util;

    /// <summary>
    /// The generic entity business logic.
    /// </summary>
    /// <typeparam name="T">
    /// the entity type 
    /// </typeparam>
    internal class GenericEntityBl<T>
        where T : class
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
            var response = this.ValidateEntity(entity);
            if (response != null)
            {
                return response;
            }

            using (GiUnitOfWork unitOfWork = new GiUnitOfWork())
            {
                unitOfWork.GetRepository<T>().Insert(entity);
                unitOfWork.Save();
                return new Response<T>() { OperationResult = entity, IsValid = true, Error = new List<string>() };
            }
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>.
        /// </returns>
        public Response<T> Update(T entity)
        {
            var response = this.ValidateEntity(entity);
            if (response != null)
            {
                return response;
            }

            using (GiUnitOfWork unitOfWork = new GiUnitOfWork())
            {
                unitOfWork.GetRepository<T>().Update(entity);
                unitOfWork.Save();
                return new Response<T>() { OperationResult = entity, IsValid = true, Error = new List<string>() };
            }
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>.
        /// </returns>
        public Response<T> Delete(T entity)
        {
            using (GiUnitOfWork unitOfWork = new GiUnitOfWork())
            {
                unitOfWork.GetRepository<T>().Delete(entity);
                unitOfWork.Save();
                return new Response<T>() { OperationResult = entity, IsValid = true, Error = new List<string>() };
            }
        }

        /// <summary>
        /// The get by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>.
        /// </returns>
        public Response<T> GetById(object id)
        {
            using (GiUnitOfWork unitOfWork = new GiUnitOfWork())
            {
                return new Response<T>()
                {
                    OperationResult = unitOfWork.GetRepository<T>().GetById(id),
                    IsValid = true,
                    Error = new List<string>()
                };
            }
        }

        /// <summary>
        /// The validate entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>.
        /// </returns>
        private Response<T> ValidateEntity(T entity)
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

            return null;
        }
    }
}
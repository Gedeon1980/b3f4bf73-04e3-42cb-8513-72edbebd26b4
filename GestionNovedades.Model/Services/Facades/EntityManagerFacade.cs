﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityManagerFacade.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The entity manager facade.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Services.Facades
{
    using GestionNovedades.Model.BusinessLogic.BL;
    using GestionNovedades.Model.Entidades;
    using GestionNovedades.Model.Util;

    /// <summary>
    /// The entity manager facade.
    /// </summary>
    public class EntityManagerFacade : IEntityManagerFacade
    {
        #region roles

        /// <summary>
        /// The insert role.
        /// </summary>
        /// <param name="role">
        /// The role.
        /// </param>
        /// <returns>
        /// The <see cref="Response{T}"/>.
        /// </returns>
        public Response<Role> InsertRole(Role role)
        {
            return new GenericEntityBl<Role>().Insert(role);
        }
        ////TODO: AGREGAR TODAS LAS ENTIDADES A LA FA
        #endregion 
    }
}

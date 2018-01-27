// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntityManagerFacade.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the IEntityManagerFacade type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Services.Facades
{
    using System.ServiceModel;

    using GestionNovedades.Model.Entidades;
    using GestionNovedades.Model.Util;

    /// <summary>
    /// The EntityManagerFacade interface.
    /// </summary>
    [ServiceContract]
    public interface IEntityManagerFacade
    {
        /// <summary>
        /// The insert role.
        /// </summary>
        /// <param name="role">
        /// The role.
        /// </param>
        /// <returns>
        /// The <see cref="Response"/>.
        /// </returns>
        [OperationContract]
        Response<Role> InsertRole(Role role);
    }
}
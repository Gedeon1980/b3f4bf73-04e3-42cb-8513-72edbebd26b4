// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the RoleValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The role validator.
    /// </summary>
    internal class RoleValidator : EntityValidator<Role>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleValidator"/> class.
        /// </summary>
        public RoleValidator()
        {
            this.RuleFor(r => r.RoleDescription).NotEmpty().WithMessage("La description del rol no puede ser vacio");
        }
    }
}

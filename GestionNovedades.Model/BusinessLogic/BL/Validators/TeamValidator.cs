// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the TeamValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The team validator.
    /// </summary>
    internal class TeamValidator : EntityValidator<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamValidator"/> class.
        /// </summary>
        public TeamValidator()
        {
            this.RuleFor(r => r.SettledId).NotEmpty().WithMessage(string.Empty);
            this.RuleFor(r => r.EmployeeId).NotEmpty().WithMessage(string.Empty);
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the CompanyValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Configuration;
    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The company validator.
    /// </summary>
    internal class CompanyValidator : EntityValidator<Company>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyValidator"/> class.
        /// </summary>
        public CompanyValidator()
        {
            this.RuleFor(r => r.CompanyName).NotEmpty().WithMessage(GestionNovedadesConfig.Instance.GetLocaleString("EmptyCompanyName"));
            this.RuleFor(r => r.CompanyIdentification).NotEmpty().WithMessage(GestionNovedadesConfig.Instance.GetLocaleString("EmptyCompanyId"));
        }
    }
}

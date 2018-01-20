// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncidentsValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the IncidentsValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The incidents validator.
    /// </summary>
    internal class IncidentsValidator : EntityValidator<Incidents>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentsValidator"/> class.
        /// </summary>
        public IncidentsValidator()
        {
            this.RuleFor(r => r.IncidentMoved).NotEmpty().WithMessage("El incidente no puede tener la fecha de traslado vacia");
            this.RuleFor(r => r.IncidentSolved).NotEmpty().WithMessage("El incidente no puede tener la fecha de solucion vacia");
            this.RuleFor(r => r.IncidentStart).NotEmpty().WithMessage("El incidente no puede tener la fecha de inicio vacia");
        }
    }
}

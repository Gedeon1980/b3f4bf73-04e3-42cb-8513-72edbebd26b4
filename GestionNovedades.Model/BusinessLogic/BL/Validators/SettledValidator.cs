﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SettledValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the SettledValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The settled validator.
    /// </summary>
    internal class SettledValidator : EntityValidator<Settled>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettledValidator"/> class.
        /// </summary>
        public SettledValidator()
        {
            this.RuleFor(r => r.CompanyReportId).NotEmpty().WithMessage("El incidente no puede tener el IdCompania vacio");
            this.RuleFor(r => r.SettledNumber).NotEmpty().WithMessage("El incidente no puede tener el NumeroProceso");
            this.RuleFor(r => r.SettledDeliver).NotEmpty().WithMessage("El incidente no puede tener la Fechac de Entrega vacia");
            this.RuleFor(r => r.SettledEnd).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Finalizacion vacia");
            this.RuleFor(r => r.SettledId).NotEmpty().WithMessage("El incidente no puede tener el IdRadicado vacio");
            this.RuleFor(r => r.SettledLastRevision).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Ultima Revision vacia");
            this.RuleFor(r => r.SettledStart).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Inicio vacia");
            this.RuleFor(r => r.State).NotEmpty().WithMessage("El incidente no puede tener el Estado vacio");
            this.RuleFor(r => r.Description).NotEmpty().WithMessage("El incidente no puede tener la Descripcion vacia");
        }
    }
}

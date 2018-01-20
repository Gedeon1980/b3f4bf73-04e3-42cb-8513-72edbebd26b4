// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeValidator.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the EmployeeValidator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    using FluentValidation;

    using GestionNovedades.Model.Entidades;

    /// <summary>
    /// The employee validator.
    /// </summary>
    internal class EmployeeValidator : EntityValidator<Employee>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeValidator"/> class.
        /// </summary>
        public EmployeeValidator()
        {
            RuleFor(r => r.EmployeeIdentification).NotEmpty().WithMessage("La identificacion del empelado no puede estar vacia");
            RuleFor(r => r.EmployeeName).NotEmpty().WithMessage("El nombre del empleado no puede estar vacio");
            RuleFor(r => r.EmployeeRoleId).NotEmpty().WithMessage("El empleado debe tenr un rol asignado");
        }
    }
}

using FluentValidation;
using GestionNovedades.Model.Entidades;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class EmployeeValidator:EntityValidator<Employee> 
    {
        public EmployeeValidator ()
        {
            RuleFor(r => r.EmployeeIdentification).NotEmpty().WithMessage("La identificacion del empelado no puede estar vacia");
            RuleFor(r => r.EmployeeName).NotEmpty().WithMessage("El nombre del empleado no puede estar vacio");
            RuleFor(r => r.EmployeeRoleId).NotEmpty().WithMessage("El empleado debe tenr un rol asignado");
        }
    }
}

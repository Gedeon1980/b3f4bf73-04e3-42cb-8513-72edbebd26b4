using FluentValidation;
using GestionNovedades.Model.Entidades;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class RoleValidator :EntityValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(r => r.RoleDescription).NotEmpty().WithMessage("La description del rol no puede ser vacio");
        }
    }
}

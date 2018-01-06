using FluentValidation;
using GestionNovedades.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

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

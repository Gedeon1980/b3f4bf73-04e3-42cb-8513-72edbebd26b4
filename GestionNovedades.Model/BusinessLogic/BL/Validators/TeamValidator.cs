using FluentValidation;
using GestionNovedades.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class TeamValidator:EntityValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(r => r.SettledId).NotEmpty().WithMessage("");
            RuleFor(r => r.EmployeeId).NotEmpty().WithMessage("");
        }
    }
}

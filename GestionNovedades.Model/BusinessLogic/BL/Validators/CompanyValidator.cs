using FluentValidation;
using GestionNovedades.Model.Entidades;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class CompanyValidator:EntityValidator<Company> 
    {
        public CompanyValidator()
        {
            RuleFor(r => r.CompanyName).NotEmpty().WithMessage("El nombre de la compañia no puede estar vacia");
            RuleFor(r => r.CompanyIdentification).NotEmpty().WithMessage("La identificacion de la compañia no puede estar vacio");
        }
    }
}

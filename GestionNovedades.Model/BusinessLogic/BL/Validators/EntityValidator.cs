using FluentValidation;
using FluentValidation.Results;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class EntityValidator<T>: AbstractValidator<T>
    {
        public ValidationResult ValidateEntity(T entity)
        {
            return this.Validate(entity);
        }
    }
}

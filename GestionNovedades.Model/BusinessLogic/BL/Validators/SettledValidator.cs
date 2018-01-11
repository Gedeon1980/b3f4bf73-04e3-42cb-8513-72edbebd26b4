using FluentValidation;
using GestionNovedades.Model.Entidades;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class SettledValidator:EntityValidator<Settled>
    {
        public SettledValidator()
        {
            RuleFor(r => r.CompanyReportId).NotEmpty().WithMessage("El incidente no puede tener el IdCompania vacio");
            RuleFor(r => r.SettledNumber).NotEmpty().WithMessage("El incidente no puede tener el NumeroProceso");
            RuleFor(r => r.SettledDeliver).NotEmpty().WithMessage("El incidente no puede tener la Fechac de Entrega vacia");
            RuleFor(r => r.SettledEnd).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Finalizacion vacia");
            RuleFor(r => r.SettledId).NotEmpty().WithMessage("El incidente no puede tener el IdRadicado vacio");
            RuleFor(r => r.SettledLastRevision).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Ultima Revision vacia");
            RuleFor(r => r.SettledStart).NotEmpty().WithMessage("El incidente no puede tener la Fecha de Inicio vacia");
            RuleFor(r => r.State).NotEmpty().WithMessage("El incidente no puede tener el Estado vacio");
            RuleFor(r => r.Description).NotEmpty().WithMessage("El incidente no puede tener la Descripcion vacia");
        }
    }
}

using FluentValidation;
using GestionNovedades.Model.Entidades;

namespace GestionNovedades.Model.BusinessLogic.BL.Validators
{
    internal class IncidentsValidator:EntityValidator<Incidents>
    {
        public IncidentsValidator ()
        {
            RuleFor(r => r.IncidentMoved).NotEmpty().WithMessage("El incidente no puede tener la fecha de traslado vacia");
            RuleFor(r => r.IncidentSolved).NotEmpty().WithMessage("El incidente no puede tener la fecha de solucion vacia");
            RuleFor(r => r.IncidentStart).NotEmpty().WithMessage("El incidente no puede tener la fecha de inicio vacia");
        }
    }
}

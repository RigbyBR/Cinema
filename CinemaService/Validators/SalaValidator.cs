using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class SalaValidator : AbstractValidator<Sala>
    {
        public SalaValidator()
        {
            RuleFor(s => s.Numero)
                .GreaterThan(0).WithMessage("Numero da sala deve ser maior que 0");
            RuleFor(s => s.Capacidade)
                .GreaterThan(0).WithMessage("Capacidade deve ser maior que 0");
            RuleFor(s => s.Fileiras)
                .GreaterThan(0).WithMessage("Fileiras deve ser maior que 0");
            RuleFor(s => s.Assentos)
                .GreaterThan(0).WithMessage("Assentos deve ser maior que 0");
            RuleFor(s => s.Capacidade)
                .Equal(s => s.Fileiras * s.Assentos)
                .When(s => s.Fileiras > 0 && s.Assentos > 0)
                .GreaterThan(0).WithMessage("Capacidade deve ser igual a fileira * Assentos.");
        }
    }
}

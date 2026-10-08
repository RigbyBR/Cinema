using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoItemValidator : AbstractValidator<IngressoItem>
    {
        public IngressoItemValidator()
        {
            RuleFor(i => i.Assento)
                .GreaterThan(0).WithMessage("Assento deve ser maior que 0!");
            RuleFor(i => i.Fileira)
                .GreaterThan(0).WithMessage("Fileira deve ser maior que 0!");
        }
    }
}

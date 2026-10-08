using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    
   public class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator() 
        {
            RuleFor(s => s.Filme)
                .NotNull().WithMessage("Filme deve sr informada!");
            RuleFor(s => s.Data)
                .Must(d => d > DateTime.Now)
                .WithMessage("Data da sessão deve ser Futura!");
            RuleFor(s => s.Sala)
                .NotNull().WithMessage("Sala deve ser Informada!");
            RuleFor(s => s.Preco)
                .GreaterThan(0).WithMessage("Preço deve ser maior que 0!");
        }
    }
}

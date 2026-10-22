using FluentValidation;
using CinemaDomain;

namespace CinemaService.Validators
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(g => g.Nome)
                .NotEmpty().WithMessage("genero deve ser informado")
                .NotNull().WithMessage("genero deve ser informado")
                .Length(5, 50).WithMessage("genero deve conter entre 5 e 50 caracteres");
        }
    }
}

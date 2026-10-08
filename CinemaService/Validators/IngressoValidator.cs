using CinemaDomain;
using FluentValidation;

namespace CinemaService.Validators
{
    public class IngressoValidator : AbstractValidator<Ingresso>
    {
        public IngressoValidator()
        {
            RuleFor(i => i.Documento)
                .NotNull().WithMessage("Documento deve ser Informado!")
                .NotEmpty().WithMessage("Documento deve ser Informado!")
                .Length(11, 20).WithMessage("Documento deve conter entre 11 e 20 caracteres");

            RuleFor(i => i.DataCompra)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Data de compra não pode ser futura!");
            RuleFor(i => i.IngressoItens)
                .NotNull().WithMessage("Itens do ingresso devem ser informados")
                .NotEmpty().WithMessage("Deve haver pelo menos um item no ingresso!")
                .ForEach(item => item.SetValidator(new IngressoItemValidator()));
            RuleFor(i => i.Sessao)
                .NotNull().WithMessage("Sessão deve ser informada");
            RuleFor(i => i.ValorTotal)
                .GreaterThan(0).WithMessage("Valor total deve ser maior que 0");
            RuleFor(i => i.FormaPagamento)
                .NotNull().WithMessage("Forma de pagamento deve ser iinformada")
                .NotEmpty().WithMessage("Forma de pagamento deve ser informada")
                .Length(3, 20).WithMessage("Forma de pagamento deve ter entre 3 a 20 caracteres");
        }
    }
}

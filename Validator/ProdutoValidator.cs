using E_commerceFarmacia.Model;
using FluentValidation;

namespace E_commerceFarmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
               .NotEmpty()
               .MinimumLength(2)
               .MaximumLength(255);

            RuleFor(p => p.Descricao)
              .NotEmpty()
              .MinimumLength(5)
              .MaximumLength(500);

            RuleFor(p => p.Preco)
              .NotEmpty()
              .GreaterThan(0)
              .PrecisionScale(20, 2, false);

            RuleFor(p => p.Foto)
              .NotEmpty()
              .MinimumLength(2)
              .MaximumLength(5000);

            RuleFor(p => p.Quantidade)
              .NotEmpty()
              .MaximumLength(5000);



        }
    }
}

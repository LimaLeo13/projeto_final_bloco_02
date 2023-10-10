using E_commerceFarmacia.Model;
using FluentValidation;

namespace E_commerceFarmacia.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {

            RuleFor(c => c.Tipo)
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(255);
        }

    }
}

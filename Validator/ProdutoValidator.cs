﻿
using farmacia.Model;
using FluentValidation;

namespace E_commerceFarmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                    .NotEmpty()
                    .MinimumLength(4)
                    .MaximumLength(100);
            RuleFor(p => p.Descricao)
                    .NotEmpty()
                    .MinimumLength(5)
                    .MaximumLength(1000);
            RuleFor(p => p.Preco)
                   .NotNull()
                   .GreaterThan(0)
                   .PrecisionScale(20, 2, false);
        }

    }
}
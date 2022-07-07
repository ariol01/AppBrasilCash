using FluentValidation;

namespace AppBrasilCash.Models.Validation
{
    public class AccountValidation : AbstractValidator<Account>
    {
        public AccountValidation()
        {
            RuleFor(x => x.TaxId).NotNull().Length(11,18).WithMessage("Quantidade inválida de caractere para CPF/CNPJ.");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(60).WithMessage("O campo nome deve ter no máximo 60 caracteres,");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).WithMessage("O campo senha deve conter no mínimo 8 caracteres.");
        }
    }
}

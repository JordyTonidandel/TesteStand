using FluentValidation;
using TesteStand.Models;
using TesteStand.Utilitarios;

namespace TesteStand.Validator
{
    public class ClienteValidator : AbstractValidator<ClienteModel>
    {
        public ClienteValidator()
        {
            RuleFor(prop => prop.Razao_social).NotEmpty().WithMessage("A razão social da empresa deve ser especificada.");

            RuleFor(prop => prop.Capital).GreaterThan(0).WithMessage("O capital deve ser maior que 0.");

            RuleFor(prop => prop.Cnpj).NotNull().WithMessage("O CNPJ deve ser especificado.").Must(ValidarCnpj.IsCnpj);
        }
    }
}

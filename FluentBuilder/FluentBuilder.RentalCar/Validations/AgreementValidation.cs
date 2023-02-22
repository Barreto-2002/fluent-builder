using FluentBuilder.RentalCar.Model;
using FluentValidation;

namespace FluentBuilder.RentalCar.RentCar.Validations
{
    internal class AgreementValidation : AbstractValidator<Agreement>
    {
        public AgreementValidation()
        {
            RuleFor(agreement => agreement.Store)
                .NotEmpty()
                .WithMessage("Please specify a valid Store");

            RuleFor(agreement => agreement.Cost)
                .GreaterThan(1000)
                .WithMessage("Minimum cost is $1000.00");
        }
    }
}

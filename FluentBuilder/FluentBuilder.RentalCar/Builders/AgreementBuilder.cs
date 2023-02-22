using FluentBuilder.RentalCar.Model;
using FluentBuilder.RentalCar.RentCar.Model;
using FluentBuilder.RentalCar.RentCar.Validations;
using System.Text;

namespace FluentBuilder.RentalCar.Builders
{
    internal class AgreementBuilder
    {
        private Guid _guid;
        private string _store;
        private decimal _cost;
        private Customer _customer;
        private Veihicle _veihicle;

        internal AgreementBuilder WithIdentifier(Guid guid)
        {
            _guid = guid;
            return this;
        }

        internal AgreementBuilder WithStore(string store)
        {
            _store = store;
            return this;
        }

        internal AgreementBuilder WithCost(decimal cost)
        {
            _cost = cost;
            return this;
        }

        internal AgreementBuilder HavingCustomer(Action<CustomerBuilder> customerBuilder)
        {
            CustomerBuilder builder = new();
            customerBuilder(builder);
            _customer = builder.Builder();

            return this;
        }

        internal AgreementBuilder HavingVehicle(Action<VeihicleBuilder> action)
        {
            VeihicleBuilder builder = new();
            action(builder);
            _veihicle = builder.Builder();

            return this;
        }

        internal Agreement Builder()
        {
            var agreement = new Agreement(_guid, _store, DateTime.Today, _cost, _customer, _veihicle);

            Validate(agreement);

            return agreement;
        }

        private void Validate(Agreement agreement)
        {
            AgreementValidation agreementValidation = new();

            var validate = agreementValidation.Validate(agreement);

            if (!validate.IsValid)
            {
                StringBuilder stringBuilder = new();

                foreach (var error in validate.Errors)
                {
                    stringBuilder.Append($" {error}.");
                }

                throw new Exception($"Entity {nameof(Agreement)} in invalid mode -{stringBuilder}");
            }
        }
    }
}

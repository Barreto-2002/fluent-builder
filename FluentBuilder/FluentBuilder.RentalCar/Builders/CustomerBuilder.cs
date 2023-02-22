using FluentBuilder.RentalCar.RentCar.Model;

namespace FluentBuilder.RentalCar.Builders
{
    internal class CustomerBuilder
    {
        private string _fullName;
        private DateTime _date;

        public CustomerBuilder WithFullName(string name, string surName)
        {
            _fullName = $"{name} {surName}";

            return this;
        }

        public CustomerBuilder WithBirthDate(DateTime date)
        {
            _date = date;
            return this;
        }

        public Customer Builder() => new Customer(_fullName, _date);

    }
}
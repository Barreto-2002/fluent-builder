namespace FluentBuilder.RentalCar.RentCar.Model
{
    internal record Customer
    {
        public Customer(string name, DateTime birthDate)
        {
            FullName = name;
            BirthDate = birthDate;
        }

        public string FullName { get; init; }
        public DateTime BirthDate { get; init; }
    }
}

using FluentBuilder.RentalCar.RentCar.Model;

namespace FluentBuilder.RentalCar.Model
{
    internal record Agreement
    {
        public Agreement(Guid guid, string store, DateTime creationAt, decimal price, Customer customer, Veihicle? veihicle)
        {
            Guid = guid;
            Store = store;
            CreationAt = creationAt;
            Cost = price;
            Customer = customer;
            Veihicle = veihicle;
        }

        public Guid Guid { get; init; }
        public string Store { get; init; }
        public DateTime CreationAt { get; init; }
        public decimal Cost { get; init; }
        public Customer Customer { get; init; }
        public Veihicle? Veihicle { get; init; }
    }
}

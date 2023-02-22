namespace FluentBuilder.RentalCar.Model
{
    internal record Veihicle
    {
        public Veihicle(string name, string color, bool insurance)
        {
            Name = name;
            Color = color;
            Insurance = insurance;
        }

        public string Name { get; init; }
        public string Color { get; init; }
        public bool Insurance { get; init; }
    }
}

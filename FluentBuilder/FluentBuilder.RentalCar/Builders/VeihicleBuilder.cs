using FluentBuilder.RentalCar.Model;

namespace FluentBuilder.RentalCar.Builders
{
    internal class VeihicleBuilder
    {
        private string _name;
        private string _color;
        private bool _insurance;

        public VeihicleBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        public VeihicleBuilder WithColor(string color)
        {
            _color = color;
            return this;
        }

        public VeihicleBuilder WithInsurance(bool insurance)
        {
            _insurance = insurance;
            return this;
        }

        public Veihicle Builder() => new Veihicle(_name, _color, _insurance);
    }
}
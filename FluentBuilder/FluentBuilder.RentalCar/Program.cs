using FluentBuilder.RentalCar.Builders;
using Newtonsoft.Json;

namespace FluentBuilder.RentalCar
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                var agreement = new AgreementBuilder()
                    .WithIdentifier(Guid.NewGuid())
                    .WithStore("Barretão Rental Cars")
                    .WithCost(5999.99m)
                    .HavingCustomer(customer =>
                                    customer.WithFullName("Diego", "Barreto")
                                            .WithBirthDate(new DateTime(1986, 11, 10)))
                    .HavingVehicle(vehicle =>
                                   vehicle.WithName("Fiat Mobi")
                                          .WithColor("Black")
                                          .WithInsurance(true))
                    .Builder();

                Console.WriteLine(JsonConvert.SerializeObject(agreement, Formatting.Indented));
           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
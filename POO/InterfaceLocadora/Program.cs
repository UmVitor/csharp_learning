using System;
using InterfaceLocadora.Entities;
using System.Globalization;
using InterfaceLocadora.Services;

namespace InterfaceLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            System.Console.Write("Car model: ");
            string model = Console.ReadLine();
            System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            System.Console.Write("return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalServices rentalService = new RentalServices(hour, day);

            rentalService.ProcessInvoice(carRental);

            System.Console.WriteLine("INVOICE:");
            System.Console.WriteLine(carRental.Invoice);

        }
    }
}

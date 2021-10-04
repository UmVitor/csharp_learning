using System;
using System.Globalization;
using InterfaceLocadora.Entities;
namespace InterfaceLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter retal data:");
            System.Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            System.Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime t1 = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime t2 = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Rent car = new Rent(carModel, t1, t2, pricePerHour, pricePerDay);
            System.Console.WriteLine("INVOICE");
            System.Console.WriteLine(car);
        }   
    }
}

using System;
using System.Globalization;
using ExceptionsBank.Entities;
using ExceptionsBank.Entities.Exceptions;

namespace ExceptionsBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try{                
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter amount for withdraw: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account user = new Account(number, name, initialBalance, withDrawLimit);
                user.WithDraw(withDraw);
                Console.WriteLine("New Balance: " + user);

            }
            catch(DomainException e){
                Console.WriteLine("Withdraw error:" + e.Message);
            }
            catch(FormatException e){
                Console.WriteLine("Format error:" + e.Message);
            }
            catch(Exception e){
                Console.WriteLine("Unpected error: " + e.Message);
            }

        }
    }
}

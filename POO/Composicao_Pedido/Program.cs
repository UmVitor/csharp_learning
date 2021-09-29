using System;
using System.Globalization;
using Composicao_Pedido.Entities;
using Composicao_Pedido.Enums;

namespace Composicao_Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nome,email,birthdate);
            DateTime date = DateTime.Now;
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(date,status,client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                Console.WriteLine("Enter #" + i+1 + " item data:");
                Console.Write("Product Name: ");
                string productname = Console.ReadLine();
                Console.Write("Product Price: ");
                double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product prod = new Product(productname,productprice);
                OrderItem ordItem = new OrderItem(quantity,productprice,prod);
                order.AddItem(ordItem);
            }

            Console.WriteLine(order);

        }
    }
}

using System;
using Enum_basics.Entities;
using Enum_basics.Entities.Enums;

namespace Enum_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Conversão do Tipo enum para string 

            OrderStatus os =  Enum.Parse<OrderStatus>("Delivered"); // Conversõa de string para enum
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}

using System;
using HashCodeAndEquals.Entities;

namespace HashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client {Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client {Name = "Maria123", Email = "maria@gmail.com"};
            Client c = new Client {Name = "Alex", Email = "alex@gmail.com"};

            // System.Console.WriteLine(a.Equals(b));
            // System.Console.WriteLine(a.Equals(c));

            // System.Console.WriteLine(a.GetHashCode());
            // System.Console.WriteLine(b.GetHashCode());
            // System.Console.WriteLine(c.GetHashCode());

            // e no caso do uso de ==
            System.Console.WriteLine(a == b); //O == compara o endereço do ponteiro de cada objeto, como são objetos diferentes então a saida será false
        }
    }
}

using System;
using ComparisonEx1.Entities;
using System.Collections.Generic;

namespace ComparisonEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); //sor utilizando um delegate(referencia para a função com type safety)

            foreach (Product p in list)
            {
                System.Console.WriteLine(p);
            }
        }

    }
}

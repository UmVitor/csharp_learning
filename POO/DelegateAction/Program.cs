// Fazer um programa que, a partir de uma lista de produtos, remova da
// lista somente aqueles cujo preço mínimo seja 100.
using System;
using System.Collections.Generic;
using DelegatePredicate.Entities;

namespace DelegatePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(UpdatePrice); // forma 1

           Action<Product> act = UpdatePrice; // forma 2
           list.ForEach(act);

            // Action<Product> act = p => {p.Price += p.Price * 0.1; }; // forma 3
            //list.ForEach(act);

            //list.ForEach(p => {p.Price += p.Price * 0.1; }); //forma 4


            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
            public static void UpdatePrice(Product p){
                p.Price += p.Price * 0.1;
            }
    }
}

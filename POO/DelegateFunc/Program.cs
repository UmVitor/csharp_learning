// Fazer um programa que, a partir de uma lista de produtos, gere uma
// nova lista contendo os nomes dos produtos em caixa alta.
using System;
using System.Collections.Generic;
using DelegatePredicate.Entities;
using System.Linq;

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

            //Forma 1
            //List<string> result = list.Select(NameUpper).ToList(); //pegamos uma lista list e aplicamos que para cada elemento dessa lista será aplicada NameUpper;
                                                                    // Então criamos uma nova coleção result, que irá receber list com NameUpper aplicado
            
            //Forma 2            
            Func<Product, string> func = NameUpper;
            List<string> result = list.Select(func).ToList();

            //forma 3 - usando expressões lambda 
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            //forma 4 - Lmabda inline
           // List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }
            public static string NameUpper(Product p){
                return p.Name.ToUpper();
            }
    }
}

// Fazer um programa para ler um conjunto de produtos a partir de um
// arquivo em formato .csv (suponha que exista pelo menos um produto).
// Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
// nomes, em ordem decrescente, dos produtos que possuem preço
// inferior ao preço médio.
//csv file
// Tv,900.00
// Mouse,50.00
// Tablet,350.50
// HD Case,80.90
// Computer,850.00
// Monitor,290.00
using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using LINQEx3.Entities;

namespace LINQEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Enter full file path");
            // string path = Console.ReadLine();
            string path = @"C:\temp1\InLINQ.csv";

            List<Product> list = new List<Product>();
            using (StreamReader sr = File.OpenText(path)){
                while(!sr.EndOfStream){
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            //Encontrar a media
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //valores abaixo da média, ordenados em ordem decrescente
            var names = list.Where(p=> p.Price < avg).OrderByDescending(p=> p.Name).Select(p => p.Name);
            foreach (var item in names)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

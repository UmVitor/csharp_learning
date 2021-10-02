using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaTax.Entities;

namespace HerancaTax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++){
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i'){
                    Console.Write("Health expenditures: ");
                    double healthexp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name,income,healthexp));
                }else if (ch == 'c'){
                    Console.Write("Number of employees: ");
                    int numberoffunc = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,income,numberoffunc));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach (Payer ls in list)
            {
                sum += ls.Tax();
                Console.WriteLine(ls.Name + ": $"+ ls.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }
            System.Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

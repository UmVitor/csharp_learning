// Fazer um programa para ler os dados (nome, email e salário)
// de funcionários a partir de um arquivo em formato .csv.
// Em seguida mostrar, em ordem alfabética, o email dos
// funcionários cujo salário seja superior a um dado valor
// fornecido pelo usuário.
// Mostrar também a soma dos salários dos funcionários cujo
// nome começa com a letra 'M'.
// Maria,maria @gmail.com,3200.00
// Alex, alex @gmail.com,1900.00
// Marco, marco @gmail.com,1700.00
// Bob, bob @gmail.com,3500.00
// Anna, anna @gmail.com,2800.00

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using LINQEx4.Entities;

namespace LINQEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Enter full file path");
            // string path = Console.ReadLine();
            string path = @"C:\temp1\InLINQEX2.csv";

            List<Employee> list = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name,email ,salary));
                }
            }
            System.Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            var highSalary = list.Where(p => p.Salary >= 2000.00).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (var emp in highSalary)
            {
                System.Console.WriteLine(emp);
            }

            var SumMSalary = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            System.Console.WriteLine($"Sum of salary of people whose name starts with 'M': {SumMSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;

namespace lista_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("How many employees will be registred? ");
            // int n = int.Parse(Console.ReadLine());
            // for(int i=0;i<n;i++){
            //     Console.WriteLine("Employee #" + i+1 + ":");
            //     Console.Write("Id: ") ;
            //     int id = int.Parse(Console.ReadLine());
            //     Console.Write("Name: ");
            //     string name = Console.ReadLine();
            //     Console.Write("Salary: ");
            //     double salary = double.Parse(Console.ReadLine());
            //     list.Add(new Funcionario(id,name,salary));
            // }

            list.AddRange( new Funcionario[] {  new Funcionario { id = 2, nome = "Frank", salario = 500.00 },
                                                new Funcionario { id = 3, nome = "Bob", salario = 1300.00 },
                                                new Funcionario { id = 4, nome = "Alex", salario = 2000.00 } } );

          //  Console.Write("Enter the employee id that will have salary increase: ");
           // int id_emp = int.Parse(Console.ReadLine());
           // int search = list.Find(x => x.Id == id_emp);
            // Console.WriteLine("Updated list of emplyees: ");
            // foreach(Funcionario obj in list){
            //     Console.WriteLine(obj.Id + ", " + obj.Nome
            //                       + ", " + obj.Salario);
            // }
        }
    }
}

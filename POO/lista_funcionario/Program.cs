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
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                Console.WriteLine("Employee #" + i+1 + ":");
                Console.Write("Id: ") ;
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id,name,salary));
            }

                                             
                                             

            Console.Write("Enter the employee id that will have salary increase: ");
            int id_emp = int.Parse(Console.ReadLine());
            int search = list.FindIndex(x => x.Id == id_emp);
            if(search < 0){
                Console.WriteLine("This Id not exists!\n");
            }else{
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list[search].Percentage(perc);
            }
            
            foreach(Funcionario obj in list){
                Console.WriteLine(obj.Id + ", " + obj.Nome
                                  + ", " + obj.Salario.ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}

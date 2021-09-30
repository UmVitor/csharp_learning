//Uma empresa possui funcionários próprios e terceirizados.
// Para cada funcionário, deseja-se registrar nome, horas
// trabalhadas e valor por hora. Funcionários terceirizados
// possuem ainda uma despesa adicional.
// O pagamento dos funcionários corresponde ao valor da hora
// multiplicado pelas horas trabalhadas, sendo que os
// funcionários terceirizados ainda recebem um bônus
// correspondente a 110% de sua despesa adicional.
// Fazer um programa para ler os dados de N funcionários (N
// fornecido pelo usuário) e armazená-los em uma lista. Depois
// de ler todos os dados, mostrar nome e pagamento de cada
// funcionário na mesma ordem em que foram digitados.
// Construa o programa conforme projeto ao lado. Veja
// exemplo na próxima página.
using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaFunc.Entities;

namespace HerancaFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> E_list = new List<Employee>();

            for(int i=0;i<n;i++){
                Console.WriteLine("Employee #" + (i+1) + " data:");
                Console.Write("Outsourced (y/n): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(resp == 'y'){
                    Console.Write("Additional charge: ");
                    double adcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    E_list.Add(new OutSourcedEmployee(name,hours,value,adcharge));
                }else{                    
                    E_list.Add(new Employee(name,hours,value));
                }
            }
            System.Console.WriteLine("PAYMENTS: ");
            foreach(Employee a in E_list){
                Console.WriteLine(a.Name + " - $" + a.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

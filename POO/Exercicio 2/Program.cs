using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mean;
            Funcionario[] vet = new Funcionario[2];
            vet[0] = cadastro();
            vet[1] = cadastro();
            mean = media(vet[0].salario,vet[1].salario);
            Console.WriteLine("Salario medio = {0}",mean.ToString("F2", CultureInfo.InvariantCulture));

        }

        static Funcionario cadastro(){
            Funcionario func = new Funcionario();
            Console.WriteLine("Dados do funcionario");
            Console.WriteLine("Nome:");
            func.nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            func.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return func;
        }

        static double media(double a, double b){        
            double media = (a+b)/2;
            return media;
        }
    }
}

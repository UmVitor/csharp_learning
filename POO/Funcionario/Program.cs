using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Func data = new Func();
            Console.Write("Nome: ");
            data.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            data.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            data.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            data.SalarioLiquido();
            Console.WriteLine(data);
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            data.AumentarSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine(data);
        }
    }
}

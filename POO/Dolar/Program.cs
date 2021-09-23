using System;
using System.Globalization;
namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você quer comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser padgo: " + Dolar.ValorConvertido(quantidade,cotacao).ToString(
                "F2",CultureInfo.InvariantCulture));
        }
    }
}

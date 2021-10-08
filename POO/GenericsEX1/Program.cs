// Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
// 1 a 10), e depois imprima esses números de forma organizada conforme
// exemplo. Em seguida, informar qual foi o primeiro valor informado.
// using System;
using System;
namespace GenericsEX1
{
    class Program
    {
        static void Main(string[] args)
        {// instanciando o tipo genérico T na classe PrintService podemos declara no program qualquer tipo
            PrintService<string> printService = new PrintService<string>();
            PrintService<int> printService2 = new PrintService<int>();
            
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++){
                string x = Console.ReadLine();
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}

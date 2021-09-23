using System;
using System.Globalization;

namespace Estoque_prog
{
    class Program
    {
        static void Main(string[] args)
        {


            Estoque prod = new Estoque("TV", 500.00, 10);
            prod.SetNome("TEL");
            Console.WriteLine(prod.GetNome());
            
        }

        static void Show_data(Estoque data){
            Console.WriteLine("Dados do produto: " + data);
        }
    }
}

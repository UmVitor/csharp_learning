using System;
using System.Globalization;

namespace Vetor_de_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt = int.Parse(Console.ReadLine());
            Produto[] data = new Produto[qnt];
            
            for(int i=0;i<qnt;i++){
                string name =  Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                data[i] = new Produto {Nome = name ,Preco = price};               
            }          
            
            double sum = 0.0; 
            for(int i=0;i<qnt;i++){
                sum += data[i].Preco;                
            }
            double mean = sum/qnt;
            Console.WriteLine("Avarege price = " + mean.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

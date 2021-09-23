using System;
using System.Globalization;

namespace Estoque_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entre com os dados do produto: ");
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Estoque prod = new Estoque(nome, preco, quantidade);

            Show_data(prod);
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            prod.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Show_data(prod);
            Console.Write("Digite o numeros de prudutos a serem removidos do estoque: ");
            prod.RemoverProdutos(int.Parse(Console.ReadLine()));
            Show_data(prod);
            
        }

        static void Show_data(Estoque data){
            Console.WriteLine("Dados do produto: " + data);
        }
    }
}

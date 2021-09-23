using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char decision = char.Parse(Console.ReadLine());
            double saldo = 0;
            if(decision == 's'){
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            Cadastro usuario  = new  Cadastro(conta, name, saldo);

            Console.WriteLine("Dados da conta: ");            
            Console.WriteLine(usuario);

            Console.Write("Entre com um valor para o deposito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Deposito(dep);
            Console.WriteLine(usuario);
            Console.Write("Entre com um valor para o saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Saque(saq);
            Console.WriteLine(usuario);


        }
    }
}

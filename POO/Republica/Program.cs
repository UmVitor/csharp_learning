using System;

namespace Republica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Cadastro[] usuario = new Cadastro[10];

            for(int i=0;i<n;i++){
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string nome_loc = Console.ReadLine();
                Console.Write("Email: ");
                string email_loc = Console.ReadLine();
                Console.Write("Room: ");
                int quarto_loc = int.Parse(Console.ReadLine());
                usuario[quarto_loc] = new Cadastro{Quarto = quarto_loc , Nome = nome_loc , Email = email_loc};
            }
            for(int i=0;i<9;i++){
                if(usuario[i] != null){
                    Console.WriteLine(usuario[i].Quarto + ": " + usuario[i].Nome + ", " + usuario[i].Email);
                }
            }

        }
    }
}

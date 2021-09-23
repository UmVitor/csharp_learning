using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vet_pessoa = new  Pessoa[2];
            vet_pessoa[0] = entrada();
            vet_pessoa[1] = entrada();
            
            if(vet_pessoa[0].idade > vet_pessoa[1].idade){
                Console.WriteLine("Pessoa mais velha: {0}",vet_pessoa[0].nome); 
            }else{
                Console.WriteLine("Pessoa mais velha: {0}", vet_pessoa[1].nome);
            }
        }

        static Pessoa entrada(){
            Pessoa dados = new Pessoa();
            Console.WriteLine("Dados da pessoa:");
            Console.WriteLine("Nome:");
            dados.nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            dados.idade = int.Parse(Console.ReadLine());
            return dados;
        }
    }
}

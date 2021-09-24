using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar a lista
            List<string> list = new List<string>();
            // adicionar itens na lista
            list.Add("Maria");
            list.Add("Jorge");
            list.Add("BOb");
            list.Insert(2,"Marco");

            //imprimir a lista
            foreach (string  obj in list)
            {
                Console.WriteLine(obj);
            }

            //Contar os elementos da lista
            Console.WriteLine("A lista possui " + list.Count + " elementos");

            //Encontrar um elemento com base em um predicado 
            string s1 = list.Find(x => x[0] == 'M');
            int s1_pos = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine(s1_pos);

            //filtrar a lista com base em um predicado
            List<string> list2 = list.FindAll(x => x.Length == 5); // cria uma lista a partir de list, contendo apenas elementos que possuem o tamanho 5
            foreach (string  obj in list2){
                Console.WriteLine(obj);
            }

            list.Remove("Maria"); // remove da lista o elemento "Maria"
            list.RemoveAll(x => x[0] == 'M'); // Remove todas as ocorrencias conforme o predicado(nesse caso irá remover todas as ocorrencias que comecem com a letra M)
            // caso método remove não encontre o elemento ele simplesmente não faz nada
            list.RemoveAt(2) // remove o elemento que está na posição 2
            list.RemoveRange(2,3) // remove um intervalo de elementos, nesse caso a partir da posição 2 remova 3 elementos da lista
        }
    }
}

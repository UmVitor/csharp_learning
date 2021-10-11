using System;
using System.Collections.Generic;

namespace HashSetAndHashSortEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0,2,3,4,5,6,8,10}; // Declarndo e instanciando de uma vez, lembarndo que no SortedSet mantém os elementos ordenados
            SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10};

            
            //Union de conjuntos
            SortedSet<int> c = new SortedSet<int>(a); // Inicia c com o valores de a
            c.UnionWith(b); // Une c com b, apenas os elementos que não se repetem
            PrintCollection(c);

            //intersection de conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference de consjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }
        static void PrintCollection<T>(IEnumerable<T> collection){ //IEnumerable -> interface implementada pela Collections,//implementa uma função que retona um enumarator para percorrer a coleção
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

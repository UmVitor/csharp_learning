using System;
using System.Collections.Generic;

namespace HashSetAndHashSortEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("TV")); // Checa se em set contem "TV"

            foreach(string p in set){ // Percorre e imprime o conjunto
                Console.WriteLine(p);
            }

        }
    }
}

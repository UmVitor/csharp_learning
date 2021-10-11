// Um site de internet registra um log de acessos dos usuários. Um
// registro de log consiste no nome de usuário e o instante em que o
// usuário acessou o site no padrão ISO 8601, separados por espaço,
// conforme exemplo. Fazer um programa que leia o log de acessos a
// partir de um arquivo, e daí informe quantos usuários distintos
// acessaram o site.
using System;
using System.IO;
using System.Collections.Generic;
using HashSetAndHashSortEx4.Entities;
namespace HashSetAndHashSortEx4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter file full path: ");
            string path = @"C:\\temp1\in.txt";//Console.ReadLine();
            HashSet<Person> people = new HashSet<Person>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        people.Add(new Person(line[0],DateTime.Parse(line[1])));
                    }
                    Console.WriteLine("Total Users: " + people.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


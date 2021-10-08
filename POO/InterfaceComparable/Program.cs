using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\temp1\in.csv";
            
            try{
                using(StreamReader sr = File.OpenText(path)){
                    //ler o arquivo e adciona nada string na lista list
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream){
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //ordena a lista
                    foreach(Employee emp in list){
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e){
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

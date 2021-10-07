using System;
using System.IO;
using System.Collections.Generic;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"C:\temp1\in.txt";
            
            try{
                using(StreamReader sr = File.OpenText(path)){
                    //ler o arquivo e adciona nada string na lista list
                    List<string> list = new List<string>();
                    while(!sr.EndOfStream){
                        list.Add(sr.ReadLine());
                    }
                    list.Sort(); //ordena a lista
                    foreach(string str in list){
                        Console.WriteLine(str);
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

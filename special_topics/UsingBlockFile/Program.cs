using System;
using System.IO;

namespace UsingBlockFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp1\file1.txt";
            //Fazendo com Filestream e StreamReader
            // try{
            //     using (FileStream fs = new FileStream(path, FileMode.Open)){ // será aberto no inicio do bloco e quando chegar ao fim do bloco os recursos serão fechados
            //         using (StreamReader sr = new StreamReader(fs)){
            //             while(!sr.EndOfStream){
            //                 string line = sr.ReadLine();
            //                 Console.WriteLine(line);
            //             }
            //         }
            //     }
            // }
            //Fazendo de forma resumida com File
            try{
                using(StreamReader sr = File.OpenText(path)){
                    while(!sr.EndOfStream){
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e){
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

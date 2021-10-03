using System;
using System.IO;
using System.Collections.Generic;

namespace FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp1\myfolder";
            try{
                var folders = Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories); // LIstar as pastas no diretório
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"c:\temp1\myfolder\newfolder"); 
            }
            catch (IOException e){
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}

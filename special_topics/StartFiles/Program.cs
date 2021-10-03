using System;
using System.IO;

namespace StartFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp1\file1.txt";
            string targetPath = @"c:\temp1\file2.txt";

            try{
                File.Copy(sourcePath, targetPath); // copia o arquivo sourcePath para targetPath
                // Copiando utilizando o fileinfo
                // FileInfo fileInfo =new FileInfo(sourcePath);
                // fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath); //ler as linhas do arquivo
                foreach (string line in lines)
                {
                    System.Console.WriteLine(line);
                }
            }        
            catch (IOException e){
                    System.Console.WriteLine("An error occured");
                    System.Console.WriteLine(e.Message);            
            }            
        }
    }
}

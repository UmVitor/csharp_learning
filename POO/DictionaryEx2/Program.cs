using System;
using System.IO;
using System.Collections.Generic;

namespace DictionaryEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter file full path: ");
            string path = @"C://temp1/in.txt";//Console.ReadLine();
            Dictionary<string, string> vote = new Dictionary<string, string>();
            try {
                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        if(vote.ContainsKey(line[0])){
                            vote[line[0]] = (int.Parse(vote[line[0]]) + int.Parse(line[1])).ToString();
                        }else
                        {
                            vote[line[0]] = line[1];
                        }
                    }
                    foreach (var item in vote)
                    {
                        System.Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}


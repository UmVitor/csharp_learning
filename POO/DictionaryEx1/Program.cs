using System;
using System.Collections.Generic;

namespace DictionaryEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // atribuição do dictionary
            //cookies[chave] = value
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "123127192";
            cookies["phone"] = "567562343"; //sobrescreve o valor anterior, pois o Dict não admite repretições

            Console.WriteLine(cookies["phone"]); // output -> 567562343

            cookies.Remove("email"); // irá remover a chave email
            //podemos testar se a chave email está presente no Dictionary, da seguinte forma

            if(cookies.ContainsKey("email")){
                Console.WriteLine(cookies["email"]);
            }else{
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            //imprime todos os cookies
            foreach(KeyValuePair<string, string> item in cookies){
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            //ou poderiamos fazer desta forma
            //foreach(var item in cookies){
            //	Console.WriteLine(item.Key + ": " + item.Value);
            //}
        }
    }
}

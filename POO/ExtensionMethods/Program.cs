using System;
using ExtensionMethods.Extensions;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 10, 6, 8, 10, 45);
            System.Console.WriteLine(dt.ElapsedTime());
        }
    }
}

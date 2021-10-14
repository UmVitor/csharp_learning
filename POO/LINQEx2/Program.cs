using System;
using System.Linq;

namespace LINQEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = new int[] {2, 3, 4, 5};

            //Define query expressions
            var result = numbers.Where(x => x % 2 == 0).Select(x => x*10); // even numbers and multiply all numbers by 10

            //execute the query
            foreach(int x in result){
                Console.WriteLine(x);
            }
        }
    }
}

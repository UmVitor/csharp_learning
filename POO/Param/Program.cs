using System;

namespace Param
{
    class Program
    {
        static void Main(string[] args)
        {
            //param
            int result = Calculator.Sum(10, 20, 30, 40);
            Console.WriteLine(result);

            //modificador de parâmetro ref(passagem por referencia)
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //modificador de parametro out(possui a mesma função de ref, porém não necessita que a variavel seja inicializada)
            int triple;
            Calculator.Triple_out(a,out triple);
            Console.WriteLine(triple);

        }
    }
}

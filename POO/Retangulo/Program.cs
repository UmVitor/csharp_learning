using System;
using System.Globalization;

namespace Trig_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            rentangulo data = new rentangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");
            data.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            data.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Area = " + data.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + data.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + data.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

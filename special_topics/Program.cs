using System;
using System.Globalization;

namespace special_topics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date time---------------------------------------------------
            // DateTime d1 = DateTime.Now;
            // DateTime d2 = DateTime.Today; // dia de hoje no horário 00
            // Console.WriteLine(d1);
            // Console.WriteLine(d1.Ticks);

            // DateTime d3 = new DateTime(2020,12,13); //ano/mes/dia
            // DateTime d4 = new DateTime(2020,12,13,11,20,12); //ano/mes/dia - hora/minuto/segundo
            // Console.WriteLine(d2);


            // // Conversão de string para datetime
            // DateTime d5 = DateTime.Parse("2000-08-15");
            // DateTime d6 = DateTime.Parse("2000/08/15");
            // DateTime d7 = DateTime.ParseExact("2000 08 15", "yyyy MM dd", CultureInfo.InvariantCulture); // formatar qualquer formato de data
            // DateTime d8 = DateTime.ParseExact("2000 08 15 13:05:58", "yyyy MM dd HH:mm:ss", CultureInfo.InvariantCulture); 
            // Console.WriteLine(d5);
            // Console.WriteLine(d6);
            // Console.WriteLine(d7);
            // Console.WriteLine(d8);

            //TimeSpan-----------------------------------------------
            TimeSpan t1 = new TimeSpan(0,1,30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);


        }
    }
}

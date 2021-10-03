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
            //Construtores
            // TimeSpan t1 = new TimeSpan();
            // TimeSpan t2 = new TimeSpan(900000000L); // ticks para horas
            // TimeSpan t3 = new TimeSpan(2, 11, 21); // horas, minutos, segundos
            // TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // dias, horas, minutos, segundos
            // TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // dias, horas, minutos, segundos, millissegundos
            // Console.WriteLine(t1);
            // Console.WriteLine(t2);
            // Console.WriteLine(t3);
            // Console.WriteLine(t4);
            // Console.WriteLine(t5);

            // // Utilizando o From conseguimos converter um valor para o formato TimeSpan
            // TimeSpan t1 = TimeSpan.FromDays(1.5); // TimeSpan de um dia e meio
            // TimeSpan t2 = TimeSpan.FromHours(1.5); // TimeSpan de uma hora e meia
            // TimeSpan t3 = TimeSpan.FromMinutes(1.5); //TimeSpan de um minuto e meio
            // TimeSpan t4 = TimeSpan.FromSeconds(1.5); //TimeSpan de um segundo e meio
            // TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            // TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            // Console.WriteLine(t1);
            // Console.WriteLine(t2);
            // Console.WriteLine(t3);
            // Console.WriteLine(t4);
            // Console.WriteLine(t5);
            // Console.WriteLine(t6);

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime()); // Converte o DateTime para Local
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime()); // Converte o DateTime para UTC
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());


        }
    }
}

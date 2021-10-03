// Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
// de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
// dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
// novamente a reserva com os dados atualizados. O programa não deve aceitar dados
// inválidos para a reserva, conforme as seguintes regras:
// - Alterações de reserva só podem ocorrer para datas futuras
// - A data de saída deve ser maior que a data de entrada

using System;
using ExceptionsCourse.Entities;
using ExceptionsCourse.Entities.Exceptions;

namespace ExceptionsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin ,checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin,checkout);
                System.Console.WriteLine("Reservation: " + reservation);
            }
            catch(FormatException e){
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch(DomainException e){
                Console.WriteLine("Error in domain: " + e.Message);
            }
            catch(Exception e){
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}

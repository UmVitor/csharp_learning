using System;
using HerancaAccountCasting.Entities;

namespace HerancaAccountCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria",0.0,500.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob",0.0,200.0);
            Account acc3 = new SavingsAccount(1004, "Anna",0.0,0.01);

            //DOWNCASTING 

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //Operacao Invalida, pois acc3 é SavingsAccount e é imcompativel com businessAccount
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount){ // testamos se acc3 é uma instancia de BusinessAccount 
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Outra forma de realizar o casting utilizando o "as"
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount){ // testamos se acc3 eh uma instacia de SavingsAccount
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}

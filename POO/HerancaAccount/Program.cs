using System;
using HerancaAccount.Entities;

namespace HerancaAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown",100.0,500.00);
            Console.WriteLine(account.Balance);
        }
    }
}

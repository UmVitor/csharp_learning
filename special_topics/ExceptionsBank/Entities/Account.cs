using System;
using System.Globalization;
using ExceptionsBank.Entities.Exceptions;
namespace ExceptionsBank.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(){

        }
        public Account(int number, string holder, double balance, double withDrawLimit){
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }
        public void Deposit(double amount){
            Balance += amount;
        }
        public void WithDraw(double amount){
            if(WithDrawLimit < amount){
                throw new DomainException(" The amount exceeds withdraw limit");
            }
            else if(Balance < amount ){
                throw new DomainException(" Not enough balance");
            }
            Balance -= amount;
        }
        public override string ToString(){
            return Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
namespace HerancaAccountCasting.Entities
{
    public class BusinessAccount : Account // A classe BusinessAccount herda tudo da classe Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(){

        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit ): base(number, holder, balance){ // o base reaproveita os construtores em Account
            LoanLimit = loanLimit;
        }

        public void Loan(double amount){
            if(LoanLimit <= amount){
                Balance += amount;
            }
        }
    }
}
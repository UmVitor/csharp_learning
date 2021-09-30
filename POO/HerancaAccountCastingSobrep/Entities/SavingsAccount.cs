namespace HerancaAccountCastingSobrep.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(){

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance){
            InterestRate = interestRate;
        }
        public void UpdateBalance(){
            Balance += Balance * InterestRate;
        }
        public override void WithDraw(double amount){ //utilizamos a palavra base para reaproveitar a implementação de withdraw em Account, porem adicionamos mais 2.
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
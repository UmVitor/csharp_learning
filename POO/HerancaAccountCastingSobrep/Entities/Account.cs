namespace HerancaAccountCastingSobrep.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }  
        public double Balance { get; protected set; } 

        public Account(){

        }
        public Account(int number, string holder, double balance){
            Number =number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void  WithDraw(double amount){ //utilizamos a palavra "virtual" para expressar que o método WithDrow pode ser sobrepostos nas subclasses de Account
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount){
            Balance += amount;
        }
    }
}
namespace lista_funcionario
{
    public class Funcionario
    {
        public int Id{get; set;}
        public string Nome {get; set;}
        public double Salario {get; set;}


        public Funcionario(string nome){
            Nome = nome;
        }
        public Funcionario(int id, string nome, double salario): this(nome){
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Percentage(double perc){
            perc = perc/100;
            Salario = Salario + Salario*perc;
        }

    }
}
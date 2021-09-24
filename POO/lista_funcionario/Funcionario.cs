namespace lista_funcionario
{
    public class Funcionario
    {
        public int Id{get; private set;}
        public string Nome {get; private set;}
        public double Salario {get; set;}

        public void Cadastro(int id, string nome, double salario){
            Id = id;
            Nome = nome;
            Salario = salario;
        }


    }
}
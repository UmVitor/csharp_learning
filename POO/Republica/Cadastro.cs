namespace Republica
{
    public class Cadastro
    {
        public int Quarto {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}

        public void CadastroUsuario(int quarto, string nome, string email){
            Quarto = quarto;
            Nome = nome;
            Email = email;
        }

    }
}
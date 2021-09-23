 using System;
using System.Globalization;

namespace Estoque_prog
{
    public class Estoque
    {
        // Em C# quando fomos trabalhar com atributos privados vamos adicionar o "_" na frente do atributo
        private string _nome;
        public double Preco{get; private set;} // como essa propertie não necessita de uma lógica particular, utilizamos a auto properties
        public int Quantidade{get; private set;}
        

        // Encapsulamento utilizando properties 
        public string Nome{
            get{ return _nome; }
            set{
                if(value != null && value.Length > 1 ){ // value é o nome que é atribuido na chamada do set em program
                    _nome = value;
                }
            }
        }

        

        // construtor padrao
        public Estoque(){
            
        }
        // contrutor com sobrecarga
        public Estoque(string nome, double preco) : this(){ // o this reaproveita o construtor padrão
            _nome = nome;
            Preco = preco;            

        }
        //costrutor
        public Estoque(string nome, double preco, int quantidade) : this(nome,preco){ // o this reaproveita o construtor de dois argumentos
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque(){
            return (double) Quantidade*Preco;
        }
        public void AdicionarProdutos(int quantity){
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity){
            Quantidade -= quantity;
        }

        public override string ToString(){
            return  _nome
                    + ", $ "
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " + Quantidade + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
using System;
using System.Globalization;

namespace Estoque_prog
{
    public class Estoque
    {
        public string Nome;
        public double Preco;
        public int Qnt;

        // construtor padrao
        public Estoque(){
            Quantidade = 0
        }
        // contrutor com sobrecarga
        public Estoque(string nome, double preco) : this(){ // o this reaproveita o construtor padrão
            Nome = nome;
            Preco = preco;            

        }
        //costrutor
        public Estoque(string nome, double preco, int quantidade) : this(nome,preco){ // o this reaproveita o construtor de dois argumentos
            Qnt = quantidade;
        }


        public double ValorTotalEmEstoque(){
            return (double) Qnt*Preco;
        }
        public void AdicionarProdutos(int quantity){
            Qnt += quantity;
        }
        public void RemoverProdutos(int quantity){
            Qnt -= quantity;
        }

        public override string ToString(){
            return  Nome
                    + ", $ "
                    + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " + Qnt + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
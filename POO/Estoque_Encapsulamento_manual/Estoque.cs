 using System;
using System.Globalization;

namespace Estoque_prog
{
    public class Estoque
    {
        // Em C# quando fomos trabalhar com atributos privados vamos adicionar o "_" na frente do atributo
        private string _nome;
        private double _preco;
        private int _qnt;

        // construtor padrao
        public Estoque(){
            
        }
        // contrutor com sobrecarga
        public Estoque(string nome, double preco) : this(){ // o this reaproveita o construtor padrão
            _nome = nome;
            _preco = preco;            

        }
        //costrutor
        public Estoque(string nome, double preco, int quantidade) : this(nome,preco){ // o this reaproveita o construtor de dois argumentos
            _qnt = quantidade;
        }

        //método para obter o nome do produto
        public string GetNome(){
            return _nome;
        }

        // Obter o preco
        public double GetPreco(){
            return _preco;
        }

        //Obter Quantidade
        public int GetQuantidade(){
            return _qnt;
        }

        //alterar o nome
        public void SetNome(string nome){
            if(nome != null && nome.Length > 1 ){
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque(){
            return (double) _qnt*_preco;
        }
        public void AdicionarProdutos(int quantity){
            _qnt += quantity;
        }
        public void RemoverProdutos(int quantity){
            _qnt -= quantity;
        }

        public override string ToString(){
            return  _nome
                    + ", $ "
                    + _preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " + _qnt + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
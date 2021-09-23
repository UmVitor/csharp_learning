using System;
using System.Globalization;
namespace Banco
{
    public class Cadastro
    {
        public int Numconta{get; private set;}
        public string Nome{get; set;}
        public double _saldo {get; private set;}
        private double _taxa = 5.00;

        // Construtor padrão padroa
        public Cadastro(){
            _saldo = 0;
        }

        public Cadastro(int n_conta, string nome)  : this(){ 
            Nome = nome;
            Numconta = n_conta;
        }

        public Cadastro(int n_conta, string nome, double v_inicial) : this(n_conta,nome){
            Deposito(v_inicial);
        }

        public void Deposito(double deposito){
            _saldo += deposito;
        }
        public void Saque(double saque){
            _saldo = _saldo - saque - _taxa;
        }

        public override string ToString()
        {
            return "Conta " + Numconta + ", Titular: " + Nome +
                    ", Saldo: $ " + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
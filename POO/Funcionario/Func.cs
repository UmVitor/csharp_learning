using System;
using System.Globalization;

namespace Funcionario
{
    public class Func
    {
        public string Nome;
        public double SalarioBruto;
        public double SalLiquido;
        public double Imposto;

        public double SalarioLiquido(){
            SalLiquido = SalarioBruto - Imposto;
            return SalLiquido;
        }
        
        public double AumentarSalario(double porcentagem){
            SalLiquido += SalarioBruto*(porcentagem/100.0);
            return SalLiquido;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalLiquido.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
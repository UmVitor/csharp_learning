namespace Dolar
{
    public class Dolar
    {
        public static double IOF = 0.06;

        public static double ValorConvertido(double qnt, double cot){
            return (qnt*cot) + (qnt*cot*IOF);
        }
    }
}
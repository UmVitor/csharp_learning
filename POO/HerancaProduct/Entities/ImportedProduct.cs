using System;
using System.Text;
using System.Globalization;

namespace HerancaProduct.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(){

        }
        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new  StringBuilder();
            sb.Append(Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Custom fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)+")");
            return  sb.ToString();
        }
        public double TotalPrice(){
            return Price + CustomsFee;
        }
        
    }
}
using System;
using System.Text;


namespace HerancaProduct.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(){

        }
        public UsedProduct(string name, double price, DateTime manufacureDate) : base(name, price){
            ManufactureDate = manufacureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" (USED - Manufacture date:  " + ManufactureDate.ToString("dd/MM/yyyy") + ")");
            return base.PriceTag() + sb.ToString();
        }
    }
}
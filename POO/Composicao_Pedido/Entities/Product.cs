namespace Composicao_Pedido.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){

        }

        public Product(string name, double price){
            Name = Name;
            Price = price;
        }
    }
}
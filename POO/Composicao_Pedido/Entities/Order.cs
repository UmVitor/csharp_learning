using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Composicao_Pedido.Enums;


namespace Composicao_Pedido.Entities
{
    public class Order
    {
        public DateTime Moment {get; set;}
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }  = new List<OrderItem>();        
        public Client Client {get; set;}


        public Order(){

        }
        public Order(DateTime moment, OrderStatus status, Client client){
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item){
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item){
            Items.Remove(item);
        }

        public double Total(){
            double sum =0;
            foreach(OrderItem item in Items){
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" ");
            sb.AppendLine("("+Client.BirthDate + ") - " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach(OrderItem i in Items){
                sb.AppendLine(i.Product.Name + ", $" + i.Product.Price.ToString("F2", CultureInfo.InvariantCulture) + 
                              ", Quantity: " + i.Quantity + ", Subtotal: $" + i.SubTotal().ToString("F2",CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
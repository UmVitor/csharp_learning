using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaProduct.Entities;
namespace HerancaProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> PList = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i=0;i<n;i++){
                Console.WriteLine("Product #"+(i+1) + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choice = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(choice == 'i'){
                    Console.Write("Customs fee: ");
                    double cFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    PList.Add(new ImportedProduct(name, price, cFee));
                }else if(choice == 'u'){
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date =  DateTime.Parse(Console.ReadLine());
                    PList.Add(new UsedProduct(name,price,date));
                }else{
                    PList.Add(new Product(name,price));
                }
            }
            Console.WriteLine("Price Tags");
            foreach(Product l1 in PList){
                Console.WriteLine(l1.PriceTag());
            }
        }
    }
}

using System;
using System.Linq;
using LINQEx2.Entities;
using System.Collections.Generic;
namespace LINQEx1
{
    class Program
    {
        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>(){
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // Mostrar todos os produtos que possuem um TIER 1 e com um preço menor que $900
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:",r1);

            //Mostrar somente os nomes dos produtos da categoria Tools
            var r2 = products.Where(p => p.Category.Name =="Tools").Select(p => p.Name); // o select permite fazer projeções, ele pega um Produto e devolve um resultado do tipo que eu quiser;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //produtos que comecam com a letra c
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name}); // O select(estará utilizando um objeto anônimo, ou seja um objeto que não foi declarado nas ) vai retornar apenas o nome o preco e a categoria
                                                                                                //Como tem dois campos com Name, vamos dar um apelido para o último campo e chama-lo de CategoryName
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3 );

            //produtos cujo tier da categoria seja 1, e ordenar por preco e os que tiverem preços iguais ordenar por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //pega r4 criado anteriormente so que pula os dois primeiros objetos, e pega 4 objetos.
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 AND TAKE 4",r5);

            //Pega o primeiro elemento
            var r6 = products.First();
            System.Console.WriteLine("First test1 " + r6);

            //var r7 = products.Where(p => p.Price > 3000.00).First(); // Se tentarmos chamar o First em uma colecao vazia, será gera uma exceção
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault(); // Podemos Utilizar o expressão FirstOrDefault, que caso não encontro o primeiro elemento, imprime o Default(vazio)
            System.Console.WriteLine("First or Default test2: " + r7  +"\n");

            //retonar um elemento a partir de uma busca por ID, ou retornar o default
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // não funciona se o resultado do Where der mais de um resultado
            System.Console.WriteLine("Single or default test1: " + r8 + "\n");

            //retorna nulo
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault(); 
            System.Console.WriteLine("Single or default test2: " + r9 + "\n");

            //Agregacoa
            //Preco Maximo de um produto
            var r10 = products.Max(p => p.Price);
            System.Console.WriteLine("Max price: " + r10);

            //Produto com menor preco
            var r11 = products.Min(p => p.Price);
            System.Console.WriteLine("Max price: " + r11);

            //Soma dos precos de determinados produtos
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            System.Console.WriteLine("Category 1 sum prices: " + r12 + "\n");

            //Media dos precos
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            System.Console.WriteLine("Category 1 average prices: " + r13 + "\n");

            //Meida de precos, com protecao para caso na haja elementos
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine("Category 5 average prices: " + r14 + "\n");

            //Soma dos precos desse resultado, por agregação
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x,y) => x+y);
            System.Console.WriteLine("Category 1 aggregate sum: " + r15 + "\n");
            


        }
        public static void Print<T>(string message, IEnumerable<T> collection){
            System.Console.WriteLine(message);
            foreach (T obj in collection)
            {
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine();
        }
    }
}

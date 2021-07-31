using Loja.Backend.DBObjects;
using System;
using System.Collections.Generic;

namespace Loja.Backend.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 10;
            product.Name = "Nome Teste";
            product.Description = "Descrição Teste";
            product.Price = 10;

            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(new Product()
            {
                Id = 10,
                Name = "Nome Teste 2",
                Description = "Descrição Teste 2",
                Price = 10,
            });

            foreach (Product p in products)
                Console.WriteLine(p);
        }
    }
}

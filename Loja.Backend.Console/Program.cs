using Loja.Backend.DBObjects;
using System;
using System.Collections.Generic;

namespace Loja.Backend.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Nome Teste 1",
                Description = "Descrição Teste 1",
                Price = 10,
            });
            products.Add(new Product()
            {
                Name = "Nome Teste 2",
                Description = "Descrição Teste 2",
                Price = 10,
            });

            using (LojaContext lojaContext = new LojaContext())
            {
                foreach (Product p in products)
                {
                    lojaContext.Products.Add(p);
                    lojaContext.SaveChanges();
                    Console.WriteLine(p);
                }
            }
        }
    }
}

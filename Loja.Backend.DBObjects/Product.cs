using System;

namespace Loja.Backend.DBObjects
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nDescription: {Description}\nPrice: {Price}\n";
        }
    }
}

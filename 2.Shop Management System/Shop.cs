using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Shop_Management_System
{
    public class Shop
    {
        private List<Product> Products { get; set; } = new List<Product>();
        public double TotalIncome { get; private set; }

        public void AddProduct(string name, double price, int count, char productType)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Name == name);

            if (existingProduct != null)
            {
                existingProduct.Count += count;
                Console.WriteLine("Product count updated.");
                return;
            }

            Product newProduct = productType switch
            {
                'c' => new Coffee { Name = name, Price = price, Count = count },
                't' => new Tea { Name = name, Price = price, Count = count },
                _ => null
            };

            if (newProduct != null)
            {
                Products.Add(newProduct);
                Console.WriteLine("Product added.");
            }
            else
            {
                Console.WriteLine("Invalid product type.");
            }
        }

        public void SellProduct(string name, int count)
        {
            var product = Products.FirstOrDefault(p => p.Name == name);

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            if (product.Count < count)
            {
                Console.WriteLine("Not enough stock.");
                return;
            }

            product.Count -= count;
            TotalIncome += product.Price * count;
            Console.WriteLine("Product sold.");
        }

        public void DisplayProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Count: {product.Count}, Type: {product.GetType().Name}");
            }
        }
    }

}

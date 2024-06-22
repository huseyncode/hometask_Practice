using System;
using _2.Shop_Management_System;

namespace MainShopManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nShop Management Menu:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Sell Product");
                Console.WriteLine("3. View Income");
                Console.WriteLine("4. View Products");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter product count: ");
                        int count = int.Parse(Console.ReadLine());
                        Console.Write("Enter product type (c for Coffee, t for Tea): ");
                        char type = char.Parse(Console.ReadLine().ToLower());
                        shop.AddProduct(name, price, count, type);
                        break;

                    case "2":
                        Console.Write("Enter product name to sell: ");
                        string sellName = Console.ReadLine();
                        Console.Write("Enter count to sell: ");
                        int sellCount = int.Parse(Console.ReadLine());
                        shop.SellProduct(sellName, sellCount);
                        break;

                    case "3":
                        Console.WriteLine("Total Income: " + shop.TotalIncome);
                        break;

                    case "4":
                        shop.DisplayProducts();
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

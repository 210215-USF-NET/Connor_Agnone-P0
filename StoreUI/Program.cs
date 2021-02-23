using System;
using StoreModels;
using StoreBL;
using StoreDL;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new StoreMenu(new MyStoreBL(new StoreRepoSC()));
            menu.Start();
            /*Product newProduct = new Product();
            Console.WriteLine("Enter a product name:");
            newProduct.ProductName = Console.ReadLine();
            Console.WriteLine("What's the description:");
            newProduct.ProductDescription = Console.ReadLine();
            Console.WriteLine("How much:");
            newProduct.ProductPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Setting it to the current location now...");
            newProduct.ProductLocation = newLocation;
            Console.ReadLine();
            Console.WriteLine($"Product Details:\n\tName: {newProduct.ProductName}\n\tDescription: {newProduct.ProductDescription}\n\tPrice: ${newProduct.ProductPrice}\n\tLocation Name: {newProduct.ProductLocation.LocationName}\n\tLocation Address: {newProduct.ProductLocation.LocationAddress}");*/
        }
    }
}

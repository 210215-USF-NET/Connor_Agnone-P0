using System;
using StoreModels;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Customer newCustomer = new Customer();
            Console.WriteLine("Hello. Enter the Customer name please:");
            newCustomer.CustomerName = Console.ReadLine();
            Console.WriteLine("What's your email:");
            newCustomer.CustomerEmail = Console.ReadLine();
            Console.WriteLine("Customer Entered!");
            Console.ReadLine();
            Console.WriteLine($"Customer info:\n\tName: {newCustomer.CustomerName}\n\tEmail: {newCustomer.CustomerEmail}");*/
            Location newLocation = new Location();
            Console.WriteLine("Hello. Enter the Store name please:");
            newLocation.LocationName = Console.ReadLine();
            Console.WriteLine("Address of the Store:");
            newLocation.LocationAddress = Console.ReadLine();
            Console.WriteLine("Store Entered!");
            Console.ReadLine();
            Console.WriteLine($"Store info:\n\tName: {newLocation.LocationName}\n\tAddress: {newLocation.LocationAddress}");
            Product newProduct = new Product();
            Console.WriteLine("Enter a product name:");
            newProduct.ProductName = Console.ReadLine();
            Console.WriteLine("What's the description:");
            newProduct.ProductDescription = Console.ReadLine();
            Console.WriteLine("How much:");
            newProduct.ProductPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Setting it to the current location now...");
            newProduct.ProductLocation = newLocation;
            Console.ReadLine();
            Console.WriteLine($"Product Details:\n\tName: {newProduct.ProductName}\n\tDescription: {newProduct.ProductDescription}\n\tPrice: ${newProduct.ProductPrice}\n\tLocation Name: {newProduct.ProductLocation.LocationName}\n\tLocation Address: {newProduct.ProductLocation.LocationAddress}");
        }
    }
}

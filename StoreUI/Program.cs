using System.IO;
using StoreModels;
using StoreBL;
using StoreDL;
using StoreDL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //get config file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //set up db connection
            string connectionString = configuration.GetConnectionString("StoreDB");
            DbContextOptions<StoreDBContext> options = new DbContextOptionsBuilder<StoreDBContext>()
            .UseSqlServer(connectionString)
            .Options;
            
            using var context = new StoreDBContext(options);

            IMenu menu = new StoreMenu(new MyStoreBL(new StoreRepoDB(context, new StoreMapper())));
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

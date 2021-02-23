using System;
using StoreModels;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Hello. Enter the Customer name please:");
            newCustomer.CustomerName = Console.ReadLine();
            Console.WriteLine("What's your email:");
            newCustomer.CustomerEmail = Console.ReadLine();
            Console.WriteLine("Customer Entered!");
            Console.ReadLine();
            Console.WriteLine($"Customer info:\n\tName: {newCustomer.CustomerName}\n\tEmail: {newCustomer.CustomerEmail}");
        }
    }
}

using System;
using StoreModels;
using StoreBL;
namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private IStoreBL _storeBL;
        public StoreMenu(IStoreBL storeBL)
        {
            _storeBL = storeBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do{
                Console.WriteLine("Welcome to my store! What would you like to do?");
                Console.WriteLine("[0] Create a customer");
                Console.WriteLine("[1] Create a location");
                Console.WriteLine("[2] Create a product");
                Console.WriteLine("[3] Exit.");
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "0":
                        CreateCustomer();
                        break;
                    case "1":
                        CreateLocation();
                        break;
                    case "2":
                        break;
                    case "3":
                        stay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of the menu options! D:<");
                        break;
                }
            }while(stay);
        }
        public void CreateCustomer()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Hello. Enter the Customer name please:");
            newCustomer.CustomerName = Console.ReadLine();
            Console.WriteLine("What's your email:");
            newCustomer.CustomerEmail = Console.ReadLine();
            _storeBL.CreateCustomer(newCustomer);
            Console.WriteLine("Customer Entered!");
            Console.ReadLine();
            Console.WriteLine($"Customer info:\n\tName: {newCustomer.CustomerName}\n\tEmail: {newCustomer.CustomerEmail}");
        }
        public void CreateLocation()
        {
            Location newLocation = new Location();
            Console.WriteLine("Hello. Enter the Store name please:");
            newLocation.LocationName = Console.ReadLine();
            Console.WriteLine("Address of the Store:");
            newLocation.LocationAddress = Console.ReadLine();
            _storeBL.CreateLocation(newLocation);
            Console.WriteLine("Store Entered!");
            Console.ReadLine();
            Console.WriteLine($"Store info:\n\tName: {newLocation.LocationName}\n\tAddress: {newLocation.LocationAddress}");
        }
    }
}
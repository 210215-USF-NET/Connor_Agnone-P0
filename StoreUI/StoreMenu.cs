using System;
using StoreModels;
using StoreBL;
namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private MyStoreBL _storeBL;
        public StoreMenu(MyStoreBL storeBL)
        {
            _storeBL = storeBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do{
                Console.WriteLine("Welcome to Connor's Consignment of Conjuring & Craft!");
                Console.WriteLine("Are you a new or returning customer?");
                Console.WriteLine("[0] New User");
                Console.WriteLine("[1] I'm a returning customer");
                Console.WriteLine("[2] Exit");
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "0":
                        CreateCustomer();
                        break;
                    case "1":
                        SearchCustomerName();
                        break;
                    case "2":
                        stay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of the menu options! D:<");
                        break;
                }
                Boolean hasntPicked = false;
                if(stay)
                {
                    do
                    {
                        Console.WriteLine($"Welcome {_storeBL.currentCustomer.CustomerName}!");
                        Console.WriteLine("Which of our locations do you want to look at?");
                        GetLocations();
                        Console.WriteLine("Enter ID of store you wish to shop at:");
                        userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                SetLocation(1);
                                break;
                            case "2":
                                SetLocation(2);
                                break;
                            case "3":
                                SetLocation(3);
                                break;
                            default:
                                Console.WriteLine("Invalid input! Not part of the menu options! D:<");
                                hasntPicked = true;
                                break;
                        }
                    }while(hasntPicked);
                    IMenu menu = new LocationMenu(_storeBL);
                    menu.Start();
                }
            }while(stay);
        }
        public void SetLocation(int locationID)
        {
            _storeBL.currentLocation = _storeBL.SetLocation(locationID);
            Console.WriteLine($"You picked: {_storeBL.currentLocation.LocationName}");
            Console.WriteLine("Connecting you now...");
            Console.ReadLine();
        }
        public void CreateCustomer()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Hello. Enter the Customer name please:");
            newCustomer.CustomerName = Console.ReadLine();
            Console.WriteLine("What's your email?:");
            newCustomer.CustomerEmail = Console.ReadLine();
            _storeBL.CreateCustomer(newCustomer);
            _storeBL.currentCustomer = newCustomer;
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
        public void GetCustomers()
        {
            foreach(var item in _storeBL.GetCustomers())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void GetLocations()
        {
            foreach(var item in _storeBL.GetLocations())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void GetProducts()
        {
            foreach(var item in _storeBL.GetProducts())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void SearchCustomerName()
        {
            Console.WriteLine("Enter Customer's Name:");
            Customer foundCustomer = _storeBL.SearchCustomerName(Console.ReadLine());
            if(foundCustomer == null)
            {
                Console.WriteLine("No customer found :(");
            }
            else
            {
                Console.WriteLine(foundCustomer.ToString());
                _storeBL.currentCustomer = foundCustomer;
            }
        }
        public void DeleteCustomer()
        {
            Console.WriteLine("Enter the customer to be deleted:");
            Customer customer2BDeleted = _storeBL.SearchCustomerName(Console.ReadLine());
            if(customer2BDeleted == null)
            {
                Console.WriteLine("We can't find the customer. They may have already been deleted.\nOr you typed their name wrong.");
            }
            else
            {
                _storeBL.DeleteCustomer(customer2BDeleted);
                Console.WriteLine($"Sucess!! {customer2BDeleted.CustomerName} is gone from the Customer Collection");
            }
        }
    }
}
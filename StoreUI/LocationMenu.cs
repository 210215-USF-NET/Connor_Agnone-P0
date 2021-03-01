using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
using System.Linq;
namespace StoreUI
{
    public class LocationMenu : IMenu
    {
        private MyStoreBL _storeBL;
        public LocationMenu(MyStoreBL storeBL)
        {
            _storeBL = storeBL;
        }
        public void Start()
        {
            Boolean stay = true;
            do
            {
                Console.WriteLine($"Welcome to {_storeBL.currentLocation.LocationName}, {_storeBL.currentCustomer.CustomerName}!");
                Console.WriteLine("Would you like to start an order, see our inventory, or exit?");
                Console.WriteLine("[0] Let's start an order");
                Console.WriteLine("[1] Show me the goods!");
                Console.WriteLine("[2] Exit please");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        StartOrder();
                        break;
                    case "1":
                        GetInventory();
                        break;
                    case "2":
                        stay = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! ");
                        break;
                }
            }while(stay);
        }
        public void StartOrder()
        {
            Order newOrder = new Order
            {
                LocationID = _storeBL.currentLocation.LocationID,
                CustomerID = _storeBL.currentCustomer.CustomerID,
                OrderTotal = 0,
                OrderItems = new List<OrderItems>()
            };
            List<Inventory> newInventory = new List<Inventory>();
            foreach (var item in _storeBL.GetInventories())
            {
                if(item.LocationID == _storeBL.currentLocation.LocationID)
                {
                newInventory.Add(item);
                }
            }
            Boolean orderNotComplete = true;
            do
            {
                Console.WriteLine("Enter item ID you desire. Enter 0 to get our inventory. Type 'D' to complete your order:");
                string userInput = Console.ReadLine();
                List<Product> newProucts =_storeBL.GetProducts();
                
                int amount = 0;
                switch (userInput)
                {
                    case "0":
                        GetInventory();
                        break;
                    case "1":
                        Console.WriteLine($"How much {newProucts[0].ProductName} do you want?");
                        amount = int.Parse(Console.ReadLine());
                        if(amount <= newInventory[0].InventoryQuantity)
                        {
                            newOrder.OrderItems
                            .Add(new OrderItems
                            {
                                OrderItemProduct = newProucts[0],
                                OrderQuantity = amount
                            });
                            newOrder.OrderTotal = newOrder.OrderTotal + (newOrder.OrderItems[0].OrderQuantity * newOrder.OrderItems[0].OrderItemProduct.ProductPrice); 
                        }else
                        {
                            Console.WriteLine("We don't have that many. Please try again with a lower amount.");
                        }
                        break;
                    case "2":
                        Console.WriteLine($"How much {newProucts[1].ProductName} do you want?");
                        amount = int.Parse(Console.ReadLine());
                        if(amount <= newInventory[1].InventoryQuantity)
                        {
                            newOrder.OrderItems
                            .Add(new OrderItems
                            {
                                OrderItemProduct = newProucts[1],
                                OrderQuantity = amount
                            });
                            newOrder.OrderTotal = newOrder.OrderTotal + (newOrder.OrderItems[1].OrderQuantity * newOrder.OrderItems[1].OrderItemProduct.ProductPrice); 
                        }else
                        {
                            Console.WriteLine("We don't have that many. Please try again with a lower amount.");
                        }
                        break;
                    case "D":
                        orderNotComplete = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }while(orderNotComplete);
            Console.WriteLine($"You're total is: ${newOrder.OrderTotal}");
        }
        public void GetInventory()
        {
            List<Product> newProucts =_storeBL.GetProducts();
            foreach(var item in _storeBL.GetInventories())
            {
                foreach(var product in newProucts)
                {
                    if(item.ProductID == product.ProductID)
                    {
                        if(item.LocationID == _storeBL.currentLocation.LocationID)
                        {
                            Console.WriteLine(item.ToString() + $"{product.ProductName} | Price: ${product.ProductPrice} | QTY: {item.InventoryQuantity}");
                        }
                    }
                }
                
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
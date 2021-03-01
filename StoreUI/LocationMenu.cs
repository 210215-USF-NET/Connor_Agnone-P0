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
            Console.WriteLine($"Welcome to {_storeBL.currentLocation.LocationName}, {_storeBL.currentCustomer.CustomerName}!");
            GetInventory();
            Console.ReadLine();
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
using System;
using StoreModels;
using StoreBL;
using System.Collections.Generic;
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
            //_storeBL.currentLocation.Inventory = new List<Inventory>();
            //_storeBL.currentLocation.Inventory = _storeBL.GetInventories(_storeBL.currentLocation);
            //_storeBL.currentLocation.Inventory.ToString();
            Console.ReadLine();
        }
    }
}
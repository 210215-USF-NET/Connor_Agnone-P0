using System;
using StoreModels;
using StoreBL;
namespace StoreUI
{
    public class LocationMenu : IMenu
    {
        private IStoreBL _storeBL;
        public LocationMenu(IStoreBL storeBL)
        {
            _storeBL = storeBL;
        }
        public void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
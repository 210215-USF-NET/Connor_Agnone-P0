using StoreModels;
using StoreDL;
using System;
using System.Collections.Generic;
namespace StoreBL
{
    public class StoreBL : IStoreBL
    {
        private IStoreRepository _repo;
        public StoreBL(IStoreRepository repo)
        {
            _repo = repo;
        }
        public void CreateCustomer(Customer newCustomer)
        {
            _repo.CreateCustomer(newCustomer);
        }
        public void CreateLocation(Location newLocation)
        {
            _repo.CreateLocation(newLocation);
        }
    }
}
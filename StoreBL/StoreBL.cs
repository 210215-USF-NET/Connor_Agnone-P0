using StoreModels;
using StoreDL;
using System;
using System.Collections.Generic;
namespace StoreBL
{
    public class StoreBL : IStoreBL
    {
        private IStoreRepository _repo;
        public void CreateCustomer(Customer newCustomer)
        {
            _repo.CreateCustomer(newCustomer);
        }
    }
}
using StoreModels;
using StoreDL;
using System;
using System.Collections.Generic;
namespace StoreBL
{
    public class MyStoreBL : IStoreBL
    {
        private IStoreRepository _repo;
        public MyStoreBL(IStoreRepository repo)
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
        public void CreateProduct(Product newProduct)
        {
            _repo.CreateProduct(newProduct);
        }

        public void DeleteCustomer(Customer customer2BDeleted)
        {
            _repo.DeleteCustomer(customer2BDeleted);
        }

        public List<Customer> GetCustomers()
        {
            return _repo.GetCustomers();
        }

        public List<Location> GetLocations()
        {
            return _repo.GetLocations();
        }

        public List<Product> GetProducts()
        {
            return _repo.GetProducts();
        }

        public Customer SearchCustomerName(string customer)
        {
            return _repo.SearchCustomerName(customer);
        }
    }
}
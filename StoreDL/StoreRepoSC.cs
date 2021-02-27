using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public class StoreRepoSC : IStoreRepository
    {
        public List<Customer> GetCustomers()
        {
            return Storage.AllCustomers;
        }
        public Customer CreateCustomer(Customer newCustomer)
        {
            Storage.AllCustomers.Add(newCustomer);
            return newCustomer;
        }
        public Location CreateLocation(Location newLocation)
        {
            Storage.AllLocations.Add(newLocation);
            return newLocation;
        }
        public Product CreateProduct(Product newProduct)
        {
            Storage.AllProducts.Add(newProduct);
            return newProduct;
        }

        public Customer SearchCustomerName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            throw new System.NotImplementedException();
        }
    }
}
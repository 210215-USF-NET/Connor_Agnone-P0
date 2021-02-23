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
    }
}
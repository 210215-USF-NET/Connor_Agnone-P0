using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public interface IStoreRepository
    {
        Customer CreateCustomer(Customer newCustomer);
        Location CreateLocation(Location newLocation);
        List<Customer> GetCustomers();
    }
}
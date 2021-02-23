using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public interface IStoreRepository
    {
        Customer CreateCustomer(Customer newCustomer);
        List<Customer> GetCustomers();
    }
}
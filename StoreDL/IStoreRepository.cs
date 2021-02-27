using StoreModels;
using System.Collections.Generic;
namespace StoreDL
{
    public interface IStoreRepository
    {
        Customer CreateCustomer(Customer newCustomer);
        Location CreateLocation(Location newLocation);
        Product CreateProduct(Product newProduct);
        List<Customer> GetCustomers();
        Customer SearchCustomerName(string name);
        Customer DeleteCustomer(Customer customer2BDeleted);
    }
}
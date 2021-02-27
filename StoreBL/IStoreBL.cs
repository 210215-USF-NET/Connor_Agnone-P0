using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IStoreBL
    {
        void CreateCustomer(Customer newCustomer);
        void CreateLocation(Location newLocation);
        void CreateProduct(Product newProduct);
        List<Customer> GetCustomers();
        Customer SearchCustomerName(string customer);
        void DeleteCustomer(Customer customer2BDeleted);
        List<Location> GetLocations();
        List<Product> GetProducts();
        /*void CreateProduct(Product newProduct);//manager functionality
        void CreateOrder(Order newOrder);
        //search customer, view location inventory, place order
        Customer SearchCustomer();
        void PlaceOrder();*/
    }
}
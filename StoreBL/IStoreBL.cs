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
        //Customer CurrentCustomer(Customer newCustomer);
        //Location CurrentLocation(Location newLocation);
        void DeleteCustomer(Customer customer2BDeleted);
        List<Location> GetLocations();
        List<Product> GetProducts();
        List<Inventory> GetInventories();
        void CreateOrder(Order newOrder);
        void UpdateInventory(Order newOrder);
        /*void CreateProduct(Product newProduct);//manager functionality
        //search customer, view location inventory, place order
        Customer SearchCustomer();
        void PlaceOrder();*/
    }
}
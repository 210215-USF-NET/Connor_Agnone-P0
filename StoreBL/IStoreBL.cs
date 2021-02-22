using StoreModels;
using System.Collections.Generic;
namespace StoreBL
{
    public interface IStoreBL
    {
        void CreateCustomer(Customer newCustomer);
        void CreateProduct(Product newProduct);//manager functionality
        void CreateOrder(Order newOrder);
        //search customer, view location inventory, place order
        Customer SearchCustomer();
        void PlaceOrder();
    }
}
using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreModels;
using StoreDL;

namespace StoreDL
{
    public class StoreMapper : IMapper
    {
        public Model.Customer ParseCustomer(Entity.Customer customer)
        {
            return new Model.Customer
            {
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                CustomerID = customer.Id
            };
        }

        public Entity.Customer ParseCustomer(Model.Customer customer)
        {
            if(customer.CustomerID == null)
            {
                return new Entity.Customer
                {
                    CustomerName = customer.CustomerName,
                    CustomerEmail = customer.CustomerEmail
                };
            }
            return new Entity.Customer
            {
                CustomerName = customer.CustomerName,
                CustomerEmail = customer.CustomerEmail,
                Id = (int)customer.CustomerID
            };
        }
    }
}
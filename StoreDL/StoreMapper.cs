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

        public Model.Inventory ParseInventory(Entity.Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public Entity.Inventory ParseInventory(Model.Inventory inventory)
        {
            throw new System.NotImplementedException();
        }

        public Model.Location ParseLocation(Entity.Location location)
        {
            return new Model.Location
            {
                LocationName = location.LocationName,
                LocationAddress = location.LocationAddress,
                LocationID = location.Id
            };
        }

        public Entity.Location ParseLocation(Model.Location location)
        {
            if(location.LocationID == null)
            {
                return new Entity.Location
                {
                    LocationName = location.LocationName,
                    LocationAddress = location.LocationAddress
                };
            }
            return new Entity.Location
            {
                LocationName = location.LocationName,
                LocationAddress = location.LocationAddress,
                Id = (int)location.LocationID
            };
        }

        public Model.Product ParseProduct(Entity.Product product)
        {
            return new Model.Product
            {
                ProductName = product.ProductName,
                ProductPrice = (decimal)product.ProductPrice,
                ProductID = product.Id
            };
        }

        public Entity.Product ParseProduct(Model.Product product)
        {
            if(product.ProductID == null)
            {
                return new Entity.Product
                {
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice
                };
            }
            return new Entity.Product
            {
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                Id = (int)product.ProductID
            };
        }
    }
}
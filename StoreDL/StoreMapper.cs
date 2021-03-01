using Model = StoreModels;
using Entity = StoreDL.Entities;
using StoreModels;
using StoreDL;
using System.Collections.Generic;
using System.Linq;
using StoreDL.Entities;

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
            return new Model.Inventory
            {
                InventoryQuantity = inventory.Quantity,
                InventoryProduct = ParseProduct(inventory.InventoryProductNavigation),
                InventoryID = inventory.Id,
                ProductID = inventory.InventoryProduct,
                LocationID = inventory.InventoryLocation
            };
        }
        public Entity.Inventory ParseInventory(Model.Inventory inventory)
        {
            if(inventory.InventoryID == null)
            {
                return new Entity.Inventory
                {

                };
            }
            return new Entity.Inventory
            {
                Id = (int)inventory.InventoryID,
                Quantity = inventory.InventoryQuantity,
                InventoryLocation = (int) inventory.InventoryID
            };
        }
        /*************************************************************************
                What needs done here:
                figure out how to get inventory for whatever store location
                orders and orderitems will be a similar problem
                -tried forcing it with ToList()
                Make menus better
                Need to make Unit Tests!
                Do Logs!!!!
        *************************************************************************/
        public Model.Location ParseLocation(Entity.Location location)
        {
            return new Model.Location
            {
                LocationName = location.LocationName,
                LocationAddress = location.LocationAddress,
                LocationID = location.Id,
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

        public Model.Order ParseOrder(Entity.Order order)
        {
            throw new System.NotImplementedException();
        }

        public Entity.Order ParseOrder(Model.Order order)
        {
            throw new System.NotImplementedException();
        }

        public OrderItems ParseOrderItems(OrderItem orderItem)
        {
            throw new System.NotImplementedException();
        }

        public OrderItem ParseOrderItems(OrderItems orderItem)
        {
            throw new System.NotImplementedException();
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
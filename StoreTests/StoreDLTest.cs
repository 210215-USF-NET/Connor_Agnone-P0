using System;
using Xunit;
using Microsoft.EntityFrameworkCore;
using StoreDL;
using Entity = StoreDL.Entities;
using Model = StoreModels;
using System.Linq;
namespace StoreTests
{
    public class StoreDLTest
    {
        private readonly DbContextOptions<Entity.StoreDBContext> options;
        public StoreDLTest()
        {
            options = new DbContextOptionsBuilder<Entity.StoreDBContext>()
            .UseSqlite("Filename=Test.db")
            .Options;
            Seed();
        }
        //testing read operations
        [Fact]
        public void GetCustomersShouldReturnAllCustomers()
        {
            using(var context = new Entity.StoreDBContext(options))
            {
                IStoreRepository _repo = new StoreRepoDB(context, new StoreMapper());
                var customers = _repo.GetCustomers();
                Assert.Equal(2, customers.Count);
            }
        }
        private void Seed()
        {
            using(var context = new Entity.StoreDBContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Customers.AddRange
                (
                    new Entity.Customer
                    {
                        Id = 1,
                        CustomerName = "Joe",
                        CustomerEmail = "joe@email.com"
                    },
                    new Entity.Customer
                    {
                        Id = 2,
                        CustomerName = "Sally",
                        CustomerEmail = "sallyride@email.com"
                    }
                );
                context.Locations.AddRange
                (
                    new Entity.Location
                    {
                        Id = 1,
                        LocationName = "Bats and Brews",
                        LocationAddress = "55 Bat Dr."
                    },
                    new Entity.Location
                    {
                        Id = 2,
                        LocationName = "Goblin's and Ghouls",
                        LocationAddress = "42 Universe St"
                    }
                );
                context.Products.AddRange
                (
                    new Entity.Product
                    {
                        Id = 1,
                        ProductName = "Eye of Newt",
                        ProductPrice = 1
                    },
                    new Entity.Product
                    {
                        Id = 2,
                        ProductName = "Bat Wool",
                        ProductPrice = 3
                    },
                    new Entity.Product
                    {
                        Id = 3,
                        ProductName = "Mandrake",
                        ProductPrice = 12
                    }
                );
                context.Inventories.AddRange
                (
                    new Entity.Inventory
                    {
                        Id = 1,
                        InventoryProduct = 1,
                        InventoryLocation = 1,
                        Quantity = 12
                    },
                    new Entity.Inventory
                    {
                        Id = 2,
                        InventoryProduct = 2,
                        InventoryLocation = 1,
                        Quantity = 9
                    },
                    new Entity.Inventory
                    {
                        Id = 3,
                        InventoryProduct = 3,
                        InventoryLocation = 1,
                        Quantity = 3
                    },
                    new Entity.Inventory
                    {
                        Id = 4,
                        InventoryProduct = 1,
                        InventoryLocation = 2,
                        Quantity = 5
                    },
                    new Entity.Inventory
                    {
                        Id = 5,
                        InventoryProduct = 2,
                        InventoryLocation = 2,
                        Quantity = 10
                    },
                    new Entity.Inventory
                    {
                        Id = 6,
                        InventoryProduct = 3,
                        InventoryLocation = 2,
                        Quantity = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

using System.Collections.Generic;
using Model = StoreModels;
using Entity = StoreDL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StoreModels;
namespace StoreDL
{
    public class StoreRepoDB : IStoreRepository
    {
        private Entity.StoreDBContext _context;
        private IMapper _mapper;
        public StoreRepoDB(Entity.StoreDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Customer CreateCustomer(Model.Customer newCustomer)
        {
            _context.Customers.Add(_mapper.ParseCustomer(newCustomer));
            _context.SaveChanges();
            return newCustomer;
        }

        public Location CreateLocation(Location newLocation)
        {
            throw new System.NotImplementedException();
        }

        public Product CreateProduct(Product newProduct)
        {
            throw new System.NotImplementedException();
        }

        public Customer DeleteCustomer(Customer customer2BDeleted)
        {
            _context.Customers.Remove(_mapper.ParseCustomer(customer2BDeleted));
            _context.SaveChanges();
            return customer2BDeleted;
        }

        public List<Model.Customer> GetCustomers()
        {
            return _context.Customers.AsNoTracking().Select(x => _mapper.ParseCustomer(x)).ToList();
        }

        public Customer SearchCustomerName(string name)
        {
            return _context.Customers
            .AsNoTracking()
            .Select(x => _mapper.ParseCustomer(x))
            .ToList()
            .FirstOrDefault(x => x.CustomerName == name);
        }
    }
}
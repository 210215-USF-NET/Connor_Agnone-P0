using Model = StoreModels;
using Entity = StoreDL.Entities;
namespace StoreDL
{
    /// <summary>
    /// To parse from DB to models and vice versa
    /// </summary>
    public interface IMapper
    {
        Model.Customer ParseCustomer(Entity.Customer customer);
        Entity.Customer ParseCustomer(Model.Customer customer);

        
    }
}
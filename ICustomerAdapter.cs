using System.Collections.Generic;

namespace BikeShop.DAL
{
    public interface ICustomerAdapter
    {
        IEnumerable<Customer> GetAll();
    }
}
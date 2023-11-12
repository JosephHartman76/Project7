using System.Collections.Generic;

namespace BikeShop.DAL
{
    interface IInvoiceAdapter
    {
        IEnumerable<Invoice> GetAll();
        IEnumerable<Invoice> GetByCustomerId(int customerId);
        Invoice GetById(int id);
    }
}
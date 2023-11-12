using System;

namespace BikeShop.DAL
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop.DAL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
    }
}

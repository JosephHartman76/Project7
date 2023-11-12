using System;
using System.Collections.Generic;
using BikeShop.DAL;

class Program
{
    static void Main()
    {
        CustomerAdapter customerAdapter = new CustomerAdapter();
        IEnumerable<Customer> customers = customerAdapter.GetAll();

        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.CustomerId} {customer.FirstName} {customer.LastName} {customer.Country} {customer.Email}");
        }
    }
}
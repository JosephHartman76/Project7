using System;
using System.Collections.Generic;
using BikeShop.DAL;
class Program
{
    static void Main()
    {
        CustomerAdapter customerAdapter = new CustomerAdapter();
        InvoiceAdapter invoiceAdapter = new InvoiceAdapter();

        Console.WriteLine("Customers:");
        IEnumerable<Customer> customers = customerAdapter.GetAll();
        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.CustomerId} {customer.FirstName} {customer.LastName} {customer.Country} {customer.Email}");
        }

        Console.WriteLine("\nInsert a new customer:");
        InsertNewCustomer(customerAdapter);

        Console.WriteLine("\nUpdated Customers:");
        customers = customerAdapter.GetAll();
        foreach (Customer customer in customers)
        {
            Console.WriteLine($"{customer.CustomerId} {customer.FirstName} {customer.LastName} {customer.Country} {customer.Email}");
        }

        Console.WriteLine("\nInvoices for a specific customer:");
        Console.Write("Enter CustomerId to display invoices: ");
        if (int.TryParse(Console.ReadLine(), out int customerId))
        {
            IEnumerable<Invoice> invoices = invoiceAdapter.GetByCustomerId(customerId);
            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine($"{invoice.InvoiceId} {invoice.CustomerId} {invoice.Total} {invoice.InvoiceDate}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for CustomerId.");
        }
    }

    static void InsertNewCustomer(CustomerAdapter customerAdapter)
    {
        Console.Write("Enter FirstName: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter LastName: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Country: ");
        string country = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Customer newCustomer = new Customer
        {
            FirstName = firstName,
            LastName = lastName,
            Country = country,
            Email = email
        };

        customerAdapter.Insert(newCustomer);

        Console.WriteLine("Customer inserted successfully!");
    }
}
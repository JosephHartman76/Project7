using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Dapper;

namespace BikeShop.DAL
{
    class InvoiceAdapter
    {
        private string connectionString = @"Data Source= C:\Sqlite\Chinook_Sqlite_AutoIncrementPKs.sqlite";
        public IEnumerable<Invoice> GetAll()
        {
            string sql = "SELECT InvoiceId, CustomerId, Total, InvoiceDate FROM Invoice";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                return connection.Query<Invoice>(sql);
            }
        }

        public Invoice GetById(int id)
        {
            string sql = "SELECT InvoiceId, CustomerId, Total, InvoiceDate FROM Invoice WHERE InvoiceId = @InvoiceId";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Invoice>(sql, new { InvoiceId = id });
            }
        }

        public IEnumerable<Invoice> GetByCustomerId(int customerId)
        {
            string sql = "SELECT InvoiceId, CustomerId, Total, InvoiceDate FROM Invoice WHERE CustomerId = @CustomerId";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                return connection.Query<Invoice>(sql, new { CustomerId = customerId });
            }
        }
    }
}
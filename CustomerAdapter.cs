using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Dapper;

namespace BikeShop.DAL
{
    public class CustomerAdapter
    {
        private string connectionString = @"Data Source= C:\Sqlite\Chinook_Sqlite_AutoIncrementPKs.sqlite";
        public IEnumerable<Customer> GetAll()
        {
            string sql = "SELECT CustomerId, FirstName, LastName, Country, Email FROM Customer";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                return connection.Query<Customer>(sql);
            }
        }
    }
}

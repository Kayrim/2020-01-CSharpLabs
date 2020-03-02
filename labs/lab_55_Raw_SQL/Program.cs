using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace lab_55_Raw_SQL
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog = Northwind;")) {
                connection.Open();
                Console.WriteLine(connection.State);

                var sqlQuery = "select * from customers";

                // send command to database
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    // read data
                    var sqlReader = command.ExecuteReader();

                    // while(sqlReader has records coming in)
                    while (sqlReader.Read())
                    {
                        string CustomerId = sqlReader["CustomerID"].ToString();
                        string ContactName = sqlReader["ContactName"].ToString();
                        string CompanyName = sqlReader["CompanyName"].ToString();
                        string City = sqlReader["City"].ToString();

                        var customer = new Customer()
                        {
                            CustomerID = CustomerId,
                            ContactName = ContactName,
                            CompanyName = CompanyName,
                            City = City
                        };

                        customers.Add(customer);

                    }
                }




            }

            // print customers
            customers.ForEach(customer => Console.WriteLine($"{customer.CustomerID,-10}{customer.ContactName,-20}" +
                $"{customer.CompanyName,-30}{customer.City}"));
        }
    }
}

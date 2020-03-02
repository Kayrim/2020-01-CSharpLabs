using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace lab_36_Northwind_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();

            var customer01 = new Customer();
            customer01.CustomerID = "CUST1";
            customer01.ContactName = "Customer Fred";
            customer01.Print();

            // get customers
            using (var db = new NorthwindModel())
            {
                // get customers: list of customers = get the database, get all customers, put them in the list
                customers = db.Customers.ToList();
                products = db.Products.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.CustomerID}  {customer.ContactName}");
                }
                
                // print customers using .Print() method below
                foreach (var customer in customers)
                {
                    customer.Print();
                }

                // delete file if it already exists
                if (File.Exists("customers.csv")){
                    File.Delete("customers.csv");
                }
                // header line
                File.AppendAllText("customers.csv", "Customer,Name" + Environment.NewLine);
                // put data in file
                customers.ForEach(customer => customer.Print());
                products.ForEach(product => product.Print());

                // run file
                Process.Start("EXCEL", "customers.csv");
            }
        }
    }

    // CAN ADD TO CUSTOMER CLASS
    public partial class Customer {
        public void Print() {
            string content = $"{this.CustomerID},{this.ContactName}\n";  // note: \n NEW LINE
            // print customer
            Console.WriteLine(content);
            File.AppendAllText("customers.csv", content);
        }

        
    }

    public partial class Product
    {
        public void Print()
        {
            Console.WriteLine($"{ProductID} has name {ProductName}");
        }
    }
}

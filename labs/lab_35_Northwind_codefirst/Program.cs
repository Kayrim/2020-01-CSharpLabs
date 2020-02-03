using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace lab_35_Northwind_codefirst
{
    class Program
    {
       public static List<Customer> customers = new List<Customer>();
       public static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            


            using (var db = new NorthWind_Model())
            {
                customers = db.Customers.ToList();
                products = db.Products.ToList();
                if (File.Exists("customers.csv"))
                {
                    File.Delete("customers.csv");
                }

                File.AppendAllText("customers.csv", "ProductID,ProductName \n");

                customers.ForEach(customer => customer.print());
                products.ForEach(product => product.Print());

                Process.Start("EXCEL", "customers.csv");

            }
        }

       
    }

    partial class Customer
    {
        public void print()
        {
            Console.WriteLine($"{this.CustomerID} has name {this.ContactName}");
        }
    }

    public partial class Product
    {

        public void Print()
        {
            string cont = $"{ProductID},{ProductName}\n";
            Console.WriteLine(cont);
            File.AppendAllText("customers.csv", cont);
        }

    }
}

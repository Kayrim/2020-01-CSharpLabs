using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace lab_36_Northwind_core
{

    class Program
    {
        public static List<Customer> customers = new List<Customer>();
        static string path = "newCustomers.csv";
        static void Main(string[] args)
        {
            using (var db = new NorthwindDbContext())
            {
                customers = db.Customers.ToList();
            }
           // AddCustomer("john1", "SpartaGlobal");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllText(path, "ID,Name,Company,City,Country\n");
            PrintCustomers();
            Process.Start("EXCEL", path);
        }

        static void AddCustomer(String Name, String ComName)
        {
            Customer customer1 = new Customer();
            customer1.ContactName = Name;
            customer1.CompanyName = ComName;
            customers.Add(customer1);

        }

        static void PrintCustomers()
        {
            customers.ForEach(c =>
            {
                string data = $"{ c.CustomerID},{c.ContactName},{c.CompanyName},{c.City},{c.Country}\n";
                Console.WriteLine(data);
                File.AppendAllText(path, data);
            });
        }
    }
    class NorthwindDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        //Dbset Customer
        public DbSet<Customer> Customers { get; set; }
    }

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
      

        [StringLength(5)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string ContactName { get; set; }

        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }

    }

    class Product
    {

    }

    class Supplier
    {

    }

    public class TestsforNorth
    {
        public int TestCustomerList1()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Customer> customers = new List<Customer>();
                customers = db.Customers.ToList();

                return customers.Count;
            }
            

        }
        public int TestCustomerList2()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Customer> customers = new List<Customer>();
                Customer customer1 = new Customer();
                customer1.ContactName = "john1";
                customer1.CompanyName = "Sparta";
                customers = db.Customers.ToList();
                customers.Add(customer1);

                

                return customers.Count;
            }


        }
        public int TestCustomerList3()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Customer> customers = new List<Customer>();
                Customer customer1 = new Customer();
                customer1.ContactName = "john1";
                customer1.CompanyName = "Sparta";
                customers = db.Customers.ToList();
                customers.Add(customer1);

                customers.RemoveAt(customers.Count-1);



                return customers.Count;
            }


        }
    }
}

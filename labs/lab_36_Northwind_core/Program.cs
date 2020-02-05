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
        public static List<Product> products = new List<Product>();
        public static List<Category> categories = new List<Category>();
        static string path = "newCustomers.csv";
        static void Main(string[] args)
        {
            using (var db = new NorthwindDbContext())
            {
                customers = db.Customers.ToList();

                // AddCustomer("john1", "SpartaGlobal");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.AppendAllText(path, "ID,Name,Company,City,Country\n");
                //PrintCustomers();

                // Process.Start("EXCEL", path);
                Console.WriteLine($"{"john",-12}");


                // These have to be casted to be used again
                var customer01 =
                    from c in db.Customers
                    where c.City == "London" || c.City == "Berlin"
                    select c;

                PrintCustomers(customer01.ToList());



                var customList =
                    from c in db.Customers
                    select new CustomObject()
                    {
                        Name = c.ContactName,
                        City = c.City,
                        Country = c.Country
                    };

                customList.ToList().ForEach(c => Console.WriteLine($"{c.City}{c.Name}{c.Country}"));

                var customerCountByCity =
                    from c in db.Customers
                    group c by c.City into Cities
                    orderby Cities.Count() descending
                    where Cities.Count() > 1
                    select new
                    {
                        City = Cities.Key,
                        Count = Cities.Count()
                    };
                customerCountByCity.ToList().ForEach(x => Console.WriteLine($"{x.City}{x.Count}"));


                var products1 =
                    from p in db.Products
                    select p;

                var categories1 =
                    from c in db.Categories
                    select c;


                PrintProducts(products1.ToList());




                products = db.Products.ToList();
                PrintProducts(products);


                static void PrintProducts(List<Product> products)
                {
                    products.ForEach(x => Console.WriteLine($"{x.ProductID,-10}{x.ProductName,-35}{x.CategoryID,-10}{x.Category.CategoryName,-10}{x.UnitPrice,-10}{x.UnitsInStock,-10}"));
                }
            }
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

        static void PrintCustomers(List<Customer> filterCustomers)
        {
            customers = filterCustomers;
            customers.ForEach(c =>
            {
                string data = $"{ c.CustomerID},{c.ContactName},{c.CompanyName},{c.City},{c.Country}\n";
                Console.WriteLine(data);
                File.AppendAllText(path, data);
            });
        }
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

                Customer customer1 = new Customer();
                customer1.ContactName = "john1";
                customer1.CompanyName = "Sparta";
                customer1.CustomerID = "222";
                db.Customers.Add(customer1);
                db.SaveChanges();
                List<Customer> customers = db.Customers.ToList();




                return customers.Count;
            }


        }
        public int TestCustomerList3()
        {
            using (var db = new NorthwindDbContext())
            {

                var toDelete = db.Customers.Find("222");
                db.Customers.Remove(toDelete);
                db.SaveChanges();

                List<Customer> length = db.Customers.ToList();



                return length.Count;
            }


        }

        public int TestProducts()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Product> products = new List<Product>();


                products = db.Products.ToList();

                return products.Count;

            }
        }

        public int TestProductsWithGivenLetter()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Product> products = new List<Product>();

                products = db.Products.ToList();

                var productsWithP =
                    from p in db.Products
                    where p.ProductName.StartsWith("p")
                    select p;


                    return productsWithP.ToList().Count;
            }



        }
        public int TestProductsContainingGivenLetter()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Product> products = new List<Product>();

                products = db.Products.ToList();

                var productsWithP =
                    from p in db.Products
                    where p.ProductName.Contains("a")
                    select p;


                return productsWithP.ToList().Count;
            }



        }
        public int TestCustomersWithinGivenCity()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Customer> customers = new List<Customer>();

                customers = db.Customers.ToList();

                var customerCity =
                    from p in db.Customers
                    where p.City == "London"
                    select p;


                return customerCity.ToList().Count;
            }



        }
        public int TestCustomersWithGivenCountry()
        {
            using (var db = new NorthwindDbContext())
            {
                List<Customer> customers = new List<Customer>();

                customers = db.Customers.ToList();

                var customerCountry =
                    from p in db.Customers
                    group p by p.Country into Countries
                    where Countries.Count() > 3
                    select new
                    {
                        Country = Countries.Key,
                        Count = Countries.Count()
                    };


                return customerCountry.Count();
            }



        }
    }

    class CustomObject
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }

    
}

using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_37_northwind_core
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Product> products = new List<Product>();
        static List<Category> categories = new List<Category>();

        //static string CustomersPath = "customers.csv";

        static void Main(string[] args)
        {
            using (var db = new NorthwindDbContext()) {
                customers = db.Customers.ToList();
            }
            //PrintCustomers(customers);
            // Process.Start("EXCEL", CustomersPath);


            // LINQ BASIC SYNTAX
            using (var db = new NorthwindDbContext())
            {
                // LINQ BASIC (QUERY) SYNTAX 
                // NOTE : WOULD HAVE TO CAST THESE OBJECTS TO LIST OR ARRAY TO USE THEM
                var customers01 =
                    from customer in db.Customers
                    select customer;
                foreach(var customer in customers01.ToList())
                {
                    // ... iterate
                }

                var customers02 =
                    from c in db.Customers
                    where c.City == "LONDON" || c.City == "BERLIN"
                    orderby c.ContactName descending
                    select c;

                // print
                //PrintCustomers(customers02.ToList());


                // creating custom output object - LITERAL 

                var customList =
                    from c in db.Customers
                    select new
                    {
                        Name = c.ContactName,
                        City = c.City,
                        Country = c.Country
                    };
                // custom print
               // Console.WriteLine($"Customer Detail\n");
               // Console.WriteLine($"{"Name",-25}{"City",-20}{"Country"}");
               // customList.ToList().ForEach(item => Console.WriteLine($"{item.Name,-25}" +
               //     $"{item.City,-20}{item.Country}"));



                var customList2 =
                    from c in db.Customers
                    select new customObject() { Name = c.ContactName, City = c.City, Country = c.Country };


                //Console.WriteLine($"\nCustomer Detail\n");
                //Console.WriteLine($"{"Name",-25}{"City",-20}{"Country"}");
                //customList2.ToList().ForEach(item => Console.WriteLine($"{item.Name,-25}" +
                 //  $"{item.City,-20}{item.Country}"));


                // SQL has AGGREGATION ie SUM, COUNT, AVERAGE, MAX AND MIN
                // QUERY BY CITY ==> COUNT PER CITY
                var customerCountByCity =
                    from cust in db.Customers
                    group cust by cust.City into Cities
                    where Cities.Count() > 1
                    orderby Cities.Count() descending
                    select new
                    {
                        City = Cities.Key,
                        Count = Cities.Count()
                    };


                //Console.WriteLine($"\n\nLIST OF CUSTOMER COUNT BY CITY\n");
                foreach (var item in customerCountByCity.ToList())
                {
                    //Console.WriteLine($"{item.City,-20}{item.Count}");
                }

                var customerByCity = db.Customers.ToList().OrderBy(c => c.Country).ThenBy(c => c.City);
                var customersGroupedByCity = db.Customers.ToList()
                    .GroupBy(c => c.City)
                    .Where(item => item.Count()>0)
                    .OrderByDescending(item=> item.Count())
                    .ThenByDescending(item=> item.Key);

                //Console.WriteLine($"\n\nLIST OF CUSTOMER GROUPED BY CITY\n");
                foreach (var item in customersGroupedByCity.ToList())
                {
                    //Console.WriteLine($"{item.Key,-20}{item.Count()}");
                }



                // JOINING TABLES
                // PRODUCTS WILL HAVE A CATEGORY AND LINK VIA CATEGORY ID
                products =
                    (from p in db.Products
                    select p).ToList();

                // In order to add CATEGORY NAME to output, first have to pull
                // in Categories into local database store (cache)


                // NOTE : In LINQ by default we have 'LAZY LOADING' which means QUERY NOT ACTUALLY RUN
                // AND BROUGHT INTO MEMORY UNTIL WE ACTUALLY NEED THE DATA.  
                // var categories = db.Categories;   ==> LAZY LOADING (NOT RUN!)
                //                              .ToList();   ==> FORCED LOADING (QU
                categories =
                    (from c in db.Categories
                    select c).ToList();



                // print
                PrintProducts(products.ToList());


            }


        }

        #region PrintCustomers
        static void PrintCustomers(List<Customer> customers) {
            if (File.Exists("customers.csv")) File.Delete("customers.csv");       // start afresh
            File.AppendAllText("customers.csv", "ID,Name,Company,City,Country"
                 + Environment.NewLine);  // header
            // print 5 fields  ID ContactName CompanyName City Country
            customers.ForEach(c =>
            {
                string customerData = $"{c.CustomerID},{c.ContactName},{c.CompanyName}," +
                        $"{c.City},{c.Country}\n";
                Console.WriteLine(customerData);
                // output to csv 5 fields
                File.AppendAllText("customers.csv", customerData);
            });
        }
        #endregion
        #region PrintProducts
        // OOP - Pass in LIST OF PRODUCTS TO PRINT
        static void PrintProducts(List<Product> products)
        {
            // id,name, category id, unitprice, unitsinstock
            products.ForEach(p => Console.WriteLine($"{p.ProductID,-10}" +
                $"{p.ProductName,-35}{p.CategoryID,-20}{p.Category.CategoryName,-30}" +
                $"{p.UnitPrice,-15}" + $"{p.UnitsInStock}"));
        }
        #endregion



    }

    // VIEW MODEL = CLASS JUST FOR VIEWING DATA (NOT IN DATABASE)
    class customObject
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public customObject(string name, string city, string country)
        {
            this.Name = name;
            this.City = city;
            this.Country = country;
        }

        public customObject()
        {

        }
    }

}

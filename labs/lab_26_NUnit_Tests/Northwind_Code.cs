using System;
using System.Collections.Generic;
using System.Text;
using lab_37_northwind_core;
using System.Linq;

namespace lab_26_NUnit_Tests
{
    public class Northwind_Code
    {


        // 800 and 810 



        static List<Customer> customers = new List<Customer>();
        public int NumberOfNorthwindCustomers(string city)
        {
            using (var db = new  NorthwindDbContext())
            {
                if (city == null || city == "")
                {
                    return db.Customers.Count();
                }
                else
                {
                    return db.Customers.Where(c => c.City == city).Count();
                }
            }
        }


        #region TestNumberOfProductsStartingWithAndContainingAParticularLetter
        public int TestNumberOfProductsStartingWithP()
        {
            using (var db = new NorthwindDbContext())
            {
                string inputLetter = "p";
                var products1 = db.Products.Where
                    (p =>
                        p.ProductName.StartsWith("p") ||
                        p.ProductName.StartsWith("P"))
                    .Count();

                var products = (
                    from product in db.Products
                    where product.ProductName.StartsWith("p")
                    select product
                    );
                var products2 =
                    db.Products
                        .Where(p =>
                        p.ProductName.StartsWith(inputLetter.ToUpper()) ||
                        p.ProductName.StartsWith(inputLetter.ToLower()))
                        .Count();
                var products3 =
                    db.Products.Where(p => p.ProductName.StartsWith(inputLetter))
                    .Count();
                return products3;
            }
        }

        public int TestNumberOfProductsStartingWithALetter(string letter)
        {
            using (var db = new NorthwindDbContext())
            {
                var productCount =
                    db.Products
                    .Where(p => p.ProductName.StartsWith(letter))
                    .Count();
                return productCount;
            }
        }

        public int TestNumberOfProductsContainingALetter(string letter)
        {
            using (var db = new NorthwindDbContext())
            {
                var productCount =
                    db.Products
                    .Where(p => p.ProductName.Contains(letter))
                    .Count();
                return productCount;
            }
        }
        #endregion


        #region CustomerOrders
        /*
         Return total of all customer orders given a customer ID
         Total will be in the form of a decimal number in money ie £10.57 for example
         

            Click on Customer

            Customer ==> CustomerID

            Search through all orders 

            OrderID
            CustomerID  (placed the order)

            Find all orders placed by this customer : 

            Match 1) CustomerID from selected customer 
            with  2) all orders which have this CustomerID in them

            orders = db.Orders.Where(o=>o.CustomerID==customer.CustomerID).ToList<Order>();

            orders = db.Orders.Where(order=>order.CustomerID==customer.CustomerID).ToList<Order>();
             
            orders =
            (from order in db.Orders
            where order.CustomerID == customer.CustomerID
            select order).ToList<Order>();



         */

        public decimal TotalOfAllCustomerOrders(string CustomerId)
        {
            return -1.00M;
        }
        #endregion



    }
}

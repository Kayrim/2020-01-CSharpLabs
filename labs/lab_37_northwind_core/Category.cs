using System;
using System.Collections.Generic;
using System.Text;

namespace lab_37_northwind_core
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
        public Category()
        {
            this.Products = new List<Product>();
        }
    }
}

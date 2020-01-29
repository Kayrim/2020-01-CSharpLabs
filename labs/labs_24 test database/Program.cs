using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_24_test_database
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wrap our database call in a using statement
            // cleans up code afterwards even if system fails
            // New instance of the database 

            List<testtable> itemList = new List<testtable>();
                
            using (var db = new testdatabaseEntities())
            {
                //List of items = call the datababase, extract data and convert to a list
                itemList = db.testtables.ToList();
                                           
            }

            foreach (var item in itemList)
            {
                Console.WriteLine($"Name = {item.TestName} The ID is = {item.TestTableID} and age = {item.TestAge}");
            }
        }
    }
}

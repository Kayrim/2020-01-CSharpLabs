using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_test_database
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 things
            // 1 WRAP DATABASE CALL IN 'USING' STATEMENT
            //          USING ==> CLEAN UP CODE AFTERWARDS EVEN
            //                    IF SYSTEM FAILURE
            // 2 NEW INSTANCE OF DATABASE

            // EMPTY LIST TO PUT DATA IN
            List<testtable> itemList = new List<testtable>();


            using (var db = new testdatabaseEntities())
            {
                // LIST OF ITEMS = (CALL THE DATABASE), 
                //                   EXTRACT testtable DATA
                //                   CONVERT OUTPUT TO LIST TYPE
                itemList = db.testtables.ToList();
            }

            // new rabbit
            var newTestItem = new testtable()
            {
                TestName="hey this has been added", 
                TestAge=22
            };

            var newTestItem2 = new testtable();
            newTestItem2.TestName = "...";
            
            using(var db = new testdatabaseEntities())
            {
                db.testtables.Add(newTestItem);
                db.SaveChanges();
                itemList = db.testtables.ToList();
            }

            
            // FOREACH .. PRINT ITEMS
            foreach (var item in itemList)
            {
                Console.WriteLine($"{item.TestName,-15} has an ID of {item.TestTableId,-10}" +
                    $" and is {item.TestAge} years old");
            }

        }
    }
}

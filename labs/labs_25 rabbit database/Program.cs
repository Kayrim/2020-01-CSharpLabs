using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_25_rabbit_database
{
    class Program
    {
        static void Main(string[] args)
        {

            List<rabbitTable> itemList = new List<rabbitTable>();

            using (var db = new rabbitDatabaseEntities())
            {

                for (int i = 0; i < 10; i++)
                {
                    var tempRabbit = new rabbitTable()
                    {
                        RabbitAge = 1,
                        RabbitID = i,
                        RabbitName = "Name" + i

                        
                    };
                    db.rabbitTables.Add(tempRabbit);
                    db.SaveChanges();
                }

                itemList = db.rabbitTables.ToList();


            }

            foreach (var item in itemList)
            {
                Console.WriteLine($"{item.RabbitAge} Age {item.RabbitID} ID  {item.RabbitName} Name");
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace lab_50_tasks
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
            // main thread here

            // create background 'task'
            // NOTE : A NEW TASK SPAWNS A NEW 'THREAD' ON OUR COMPUTER AND THE CPU MANAGES IT (MEMORY, CPU ACCESS ETC) - NO
            // LONGER UNDER PROGRAMMER CONTROL
            // argument is delegate type
            // Lambda ==> create 'anonymous' delegate type
            //                       () input parameters
            //                             { }   code body
            //                          =>       method with no name
            var task01 = new Task(() => {
                Console.WriteLine("Running Task01");
                for(int i = 0; i <= 100; i++)
                {
                    Console.WriteLine($"Task01 in process printing {i} at {s.ElapsedMilliseconds}");
                }
            });

            // create a stopwatch to see what's happening

            s.Start();
            Console.WriteLine($"Calling Task01 at time {s.ElapsedMilliseconds}");
            task01.Start();

            // also do some synchronous work on main thread
            for (int j = 0; j <= 100; j++)
            {
                Console.WriteLine($"\t\t\tMain thread in process printing {j} at {s.ElapsedMilliseconds}");
            }


            // TASK.RUN
            var task02 = Task.Run(      () => { Console.WriteLine($"\t\t\t\t\tTask 02 is running at {s.ElapsedMilliseconds} ");        });
            var task03 = Task.Run(      () => { Console.WriteLine($"\t\t\t\t\tTask 03 is running at {s.ElapsedMilliseconds}");         });
            var task04 = Task.Run(      () => { Console.WriteLine($"\t\t\t\t\tTask 04 is running at {s.ElapsedMilliseconds}");         });


            // OLDER VARIANTS
            var task05 = Task.Factory.StartNew(() => { Console.WriteLine("Running in a TASK FACTORY "); }    );


            // ARRAY OF TASK : GOOD FOR BACKGROUND BATCH JOBS AT NIGHT - CAN RUN IN PARALLEL 
            var taskArray01 = new Task[3];
            // individual tasks in array
            taskArray01[0] = Task.Run(() => {
                Thread.Sleep(1500);
                Console.WriteLine($"\t\t\t\t\tFirst task in array at {s.ElapsedMilliseconds}");   
            });
            taskArray01[1] = Task.Run(() => {
                Thread.Sleep(1500);
                Console.WriteLine($"\t\t\t\t\tSecond task in array at {s.ElapsedMilliseconds}");   
            });
            taskArray01[2] = Task.Run(() => {
                Thread.Sleep(1500);
                Console.WriteLine($"\t\t\t\t\tThird task in array at {s.ElapsedMilliseconds}");   
            });


            // WAITING FOR TASKS
            // CAN WAIT FOR AT LEAST ONE ARRAY TASK TO COMPLETE
            Task.WaitAny(taskArray01);

            // or all
            Task.WaitAll(taskArray01);

            Console.WriteLine($"First half of program ends at time {s.ElapsedMilliseconds}");




            // returning data from a task

            // Reset stopwatch
            s.Restart();
            var task06 = Task<string>.Run(   ()=> {

                return "Task 06 returns a string";
            
            });

            Console.WriteLine(task06.Result);

            // ANONYMOUS METHODS
            // FOR LOOP 1000 TIMES
            for (int i = 0; i < 1000; i++)
            {
                // database read or file read
                // could have named method OR
                // lambda : anonymous (unnamed method) 

            }


            // RUNNING MULTIPLE NAMED METHODS IN PARALLEL
            // IMAGE 20 NIGHTLY BACKUP/CLEANUP JOBS EVERY NIGHT
            // USEFUL IF ORDER OF EXECUTION DOES NOT MATTER : RUN IN PARALLEL IE TOGETHER

            Parallel.Invoke(
                () => { 
                    NightRunTask01(); 
                    NightRunTask02(); 
                    NightRunTask03(); 
                    NightRunTask04(); 
                });

            // Can run tasks to run one, then the other 

            // Running for/foreach loop in parallel
            // for loop 
            Console.WriteLine("\n\nRunning For Loop In Parallel\n");
            Parallel.For(0, 100, i => {
                Console.WriteLine($"Running task {i} in a loop");
            });


            Console.WriteLine("\n\nAlso run a parallel FOREACH loop");
            var myArray = new string[] { "first", "second", "third" };
            Parallel.ForEach(myArray, (item) => {
                Console.WriteLine($"Printing item {item}");
            });


            // ENTITY LINQ DATABASE READS IN PARALLEL TO GET LOTS OF INFO AT SAME TIME
            // Previously we ran ENTITY in SERIAL
            var customersFromDatabase = new List<Customer>();
            var customers = customersFromDatabase.AsParallel();  // execute query in parallel

            Console.WriteLine($"Program ends at time {s.ElapsedMilliseconds} after stopwatch reset");

            Console.ReadLine();


        }
        static void NightRunTask01() { Console.WriteLine("Running night time maintenance task 01"); }
        static void NightRunTask02() { Console.WriteLine("Running night time maintenance task 02"); }
        static void NightRunTask03() { Console.WriteLine("Running night time maintenance task 03"); }
        static void NightRunTask04() { Console.WriteLine("Running night time maintenance task 04"); }
    }

    class Customer { }
}

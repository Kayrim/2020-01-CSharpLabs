using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace lab_49_async_await
{
    class Program
    {

        static List<string> fileRows = new List<string>();
        static void Main(string[] args)
        {


            // standard code is SYNCHRONOUS IE LINE BY LINE, THREAD IS ONLY ONE THREAD 
            // AND IT 'HANGS' if you have long operations
            var s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Starting stopwatch at time {s.ElapsedMilliseconds}");

            DoThis(); // sync 
            Console.WriteLine(s.ElapsedMilliseconds);

            // async operation
            // main thread will start the operation but not wait for it.  Main thread will not pause.
            // build a big text file
            //File.Delete("log.dat");
            //Console.WriteLine("\n\nBuilding text file\n\n");
            //for (int i = 0; i < 1000; i++)
            //{
            //    File.AppendAllText("log.dat", $"New log entry {i} at {DateTime.Now}\n");
            //}
            //Console.WriteLine("File built . . . \n\n");
            Console.WriteLine($"Starting async operations at {s.ElapsedMilliseconds}");
            ReadTextLines();  // async
            Console.WriteLine($"Finishing async operations at {s.ElapsedMilliseconds}");
            Console.WriteLine("Program has completed");
        }

        static void DoThis()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Finished doing this");
        }

        static async void ReadTextLines()
        {
            var array = await File.ReadAllLinesAsync("log.dat");
            fileRows.AddRange(array); // add array to list
            // print sample ie every 1000 lines

            var counter = 0;
            foreach(var item in fileRows)
            {
                Console.WriteLine(item);
                counter++;
                if (counter > 100) break;
            }
        }
    }
}

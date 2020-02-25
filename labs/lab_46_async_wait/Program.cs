using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace lab_46_async_wait
{
    class Program
    {
        static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            Console.WriteLine($"Starting Stop Watch at time {s.ElapsedMilliseconds}");
            DoThis();
            Console.WriteLine(s.ElapsedMilliseconds);

            //Console.WriteLine("\nbuilding text file\n");
            //for (int i = 0; i < 10000; i++)
            //{
            //    File.AppendAllText("log.dat", $"new log entry {i} at {DateTime.Now}");
            //}
            Console.WriteLine("File Built");
            Console.WriteLine($"Starting ASync at {s.ElapsedMilliseconds}");
            ReadTextLines();

            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine("Program Complete");

        }

        private static void DoThis()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Finished Doing This");
        }

        static async void ReadTextLines()
        {
            var array = await File.ReadAllLinesAsync("log.dat");
            list.AddRange(array);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
            
        }
    }
}

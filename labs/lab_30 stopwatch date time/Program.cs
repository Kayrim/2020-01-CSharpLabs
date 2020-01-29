using System;
using System.Diagnostics;
using System.Threading;


namespace lab_30_stopwatch_date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();

            s.Start();
            int x = 0;

            for (int i = 0; i < 1_000_000; i++)
            {
                x++;
            }
            s.Stop();
            Console.WriteLine(s.Elapsed);
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);
            Thread.Sleep(1000);
        }
    }
}

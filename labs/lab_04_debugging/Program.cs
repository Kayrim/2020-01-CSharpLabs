using System;
using System.Diagnostics;
using System.IO;  // input/output
using System.Threading;

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise : clear log file
            File.WriteAllText(@"c:\log\log.dat", "");

            int x = 10;
            x = x + 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Trace.WriteLine($"Trace WriteLine {i}");
                Debug.WriteLine($"Debug WriteLine {i}");
                Debug.WriteLineIf(i == 6, "Hey, i is 6!!!");
                File.AppendAllText("../log.dat", $"Logging i={i} at {DateTime.Now}");
                Console.WriteLine("\\");   // backslash is 'escaped character'
                Console.WriteLine("\nHello\nhello\nhello");
                File.AppendAllText(@"c:\log\log.dat", $"\nLogging i={i} at {DateTime.Now}");
                //  note : \ is a special character
                // use '@' to provide clean string 'literal'
                Thread.Sleep(1500); // milliseconds
            }

            // Print file
            var logFilePath = @"c:\log\log.dat";
            Console.WriteLine("\n\nPrinting contents of log file\n\n");
            Console.WriteLine(File.ReadAllText(logFilePath));
        }
    }
}

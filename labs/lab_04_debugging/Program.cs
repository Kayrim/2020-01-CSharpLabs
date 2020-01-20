using System;
using System.IO;
using System.Threading;

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            File.WriteAllText(@"c:\log\log.dat","");
            int x = 10;
            x = x + 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText(@"c:\log\log.dat", $"\nLogging i= {i} at {DateTime.Now}"); // @ sign will take a literal clean string
                                                                                              // Backslash / is a special character // double backslash is an escape allowing one single /

                Thread.Sleep(1000);

            }
            Console.WriteLine( File.ReadAllText(@"c:\log\log.dat"));
        }
    }
}

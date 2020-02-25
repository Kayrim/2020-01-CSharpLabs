using System;

namespace lab_52_passByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);
            DoThis(x);
            TrackThis(ref x); // permanently tracks x

        }
        static void DoThis(int x)
        {
            x = x + 10;
            Console.WriteLine(x);
        }
        static void TrackThis(ref int x)
        {
            x += 100;
            Console.WriteLine(x);
        }
    }
}

using System;

namespace lab_01_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Cos(Math.PI*45/180));
        }

        static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

using System;

namespace lab_19_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // var e = new Exception();
            //method1();   // Crashes program Overflow
            //void method1()
            //{
            //    Console.WriteLine("hello");
            //    method1();

            //}
            int x = 10;
            int y = 20;
            int b = 0;
            //int broken = y / b; //this will throw an exception NotDivisbleByZero

            try
            {
                int z = x / y;
                double a = x / y;
                Console.WriteLine($"{x}/{y} is {z}");
                int broke = y / b; //this will throw an exception NotDivisbleByZero

            }
            catch (Exception e)
            {
                Console.WriteLine($"Oops, you made a mistake {e.Message}");

               
            }
            finally
            {

            }
        }
    }
}

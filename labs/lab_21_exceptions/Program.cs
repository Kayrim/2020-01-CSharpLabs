using System;

namespace lab_21_exceptions
{
    class Program
    {
        static int number = 0;
        static void Main(string[] args)
        {
            var bigNumber = int.MaxValue;
            Console.WriteLine(bigNumber);
            checked{
                //Console.WriteLine(bigNumber + 1);
            }

            // let's crash
            //CrashMe();
            
            void CrashMe()
            {
                //Console.WriteLine("Soon to crash");
                number++;
                CrashMe();
            }


            // exceptions

            double x = 10.0;
            int y = 20;
            int a = 0;
            int trouble = y / a; // unhandled
            try {
                double z = x / y;
                double d = x / y;
                Console.WriteLine($"{x}/{y} is {z} and {d}");
                int trouble2 = y / a;  // handled
            }
            catch(DivideByZeroException e) {
                Console.WriteLine("Houston we have a problem");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("something has happened but I'm not sure what");
                Console.WriteLine(e);
            }
            finally {
                Console.WriteLine("All good");
            }
         
        }
    }
}

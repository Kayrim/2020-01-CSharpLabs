using System;

namespace lab_27_test_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This code is running");
        }
    }

    public class Addition
    {
        public int AddTwoNumbers(int x, int y)
        {
            Console.WriteLine("Hey this should appear somewhere");
            return (x + y);
        }
    }

}

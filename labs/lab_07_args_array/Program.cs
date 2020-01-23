using System;

namespace lab_07_args_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking at the arg[] array");
            foreach(string item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}

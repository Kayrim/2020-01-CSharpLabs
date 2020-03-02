using System;

namespace lab_07_argument_args_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking at the args[] array");
            foreach(string item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}

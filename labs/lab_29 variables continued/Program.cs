using System;

namespace lab_29_variables_continued
{
    class Program
    {
        static void Main(string[] args)
        {
            string s01 = "hi";
            var s02 = new String("hi");

            var Point01 = new PointOfGraph(10, 10);

            //String Formatting

            double num01 = 1.234567;
            double num02 = 8.234567;
            double long01 = 123456789;
            Console.WriteLine($"Here are some numbers");
            Console.WriteLine($"No decimal places {num01,-10:N0}{num02,-20:N0}");
            Console.WriteLine($"1 decimal place {num01,-10:N1}{num02,-20:N1}");
            Console.WriteLine($"2 decimal places {num01,-10:N2}{num02,-20:N2}");
            Console.WriteLine($"Currency {num01,-10:C}{num02,-10:C}");
            Console.WriteLine($"Exponential {long01,-10:E}{long01,-10:E}{long01,-10:E}");
        }
    }

    struct PointOfGraph
    {
        //faster then classes but only deal with primitive data - cannot be null.
        public int X;
        public int Y;
        public PointOfGraph(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

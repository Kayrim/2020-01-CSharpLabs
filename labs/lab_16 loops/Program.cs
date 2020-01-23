using System;

namespace lab_16_loops
{
    class Program
    {
        static void Main(string[] args)
        {


            doThis();


            void doThis()
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i == 10) return;
                    Console.WriteLine($"In method doThis - i is {i}");
                }
                
            }

            //Throw
            // In some bigger applications they want to track when errors occur eg from validation
            for (int ix = 0; ix < 10; ix++)
            {
                if (ix == 5)
                {
                    throw new Exception("Invalid number");
                }
            }
        }
    }
}

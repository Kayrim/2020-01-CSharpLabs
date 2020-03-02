using System;

namespace lab_23_Rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 1

            // create 100 rabbits
            // give them all ID, Name and Age
            // Print a sample (every 10 items)

            // Lab 2
            // Create a loop to 'age' the rabbits
            // Iterate 50 times and update all the ages
            // Print a sample

            // Bonus : put this into WPF!?!?!!??! Not required only if very keen
        }
    }

    class Rabbit
    {
        public int RabbitId { get; set; }
        public string RabbitName { get; set; }

        public int Age { get; set; }
    }
}

using System;

namespace lab_31_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // ENUM GOOD FOR ITEMS NOT CHANGING
            // daysofweek
            // months of year
            var fruit01 = Fruit.Apple;
            Console.WriteLine(fruit01);  //APPLE
            Console.WriteLine((int)fruit01);  // 0
            Console.WriteLine($"How many fruits?  {(int)Fruit.Count}");

            // enums can be used sometimes in POWERS OF 2 TO GENERATE CODES
            // READ = 1   WRITE = 2  EXECUTE (RUN) = 4

        }
    }



    enum Fruit
    {
        // 0,1,2,3  
        Apple, Pear, Lemon, Strawberry,Count
    }

    enum Vegetables
    {
        onion=10, leek, potato, turnip,
    }

    enum Permissions
    {
        read=1,write=2,execute=4
    }
}

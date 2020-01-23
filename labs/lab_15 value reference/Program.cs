using System;

namespace lab_15_value_reference
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = x;

            int[] xarray = { 1, 2, 4, 4, 5 };
            int[] yarray = xarray;
            yarray[3] = 20;
            foreach (var test in xarray)
            {
                Console.WriteLine(test.ToString());
            }

            Dog d = new Dog();
            int x = 5;

            Console.WriteLine(d.age);
            addOneYearToDogAge(d);
            Console.WriteLine(d.age);
            Console.WriteLine(x);
            addOne(x);
            Console.WriteLine(x);


            foreach (var test in yarray)
            {
                Console.WriteLine(test.ToString());
            }

            static void addOne(int number)
            {
                number += 1;
            }

            static void addOneYearToDogAge(Dog d)
            {
                d.age++;
            }

        }
    }
    class Dog
    {
        public int age { get; set; }
    }
}

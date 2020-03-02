using System;

namespace lab_17_value_reference_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // copy integer : what happens
            int x = 100;
            int y = x;
            x = 200;
            Console.WriteLine($"x is {x} and y is {y} (Expected)");

            // copy array : what happens when change values?
            int[] Array01 = { 100, 200, 300 };
            int[] Array02;
            Console.WriteLine(Array01[0]); //100
            Array02 = Array01;
            Console.WriteLine(Array02[0]); //100

            Array01[0] = 400;
            Console.WriteLine(Array01[0]); //400
            Console.WriteLine(Array02[0]); //400

            // create some data
            int num1 = 1000;
            var dog01 = new Dog();
            dog01.Age = 10;
            // pass into methods
            Console.WriteLine(num1);
            AddOne(num1);
            Console.WriteLine(num1);   // original UNCHANGED!
            // what happens original data?
            Console.WriteLine(dog01.Age);
            AddOneYearToDogAge(dog01);
            Console.WriteLine(dog01.Age);  // original ALTERED


        }

        // pass in value type
        static void AddOne(int number) {
            number += 1;
        }

        // pass in reference (pointer)
        static void AddOneYearToDogAge(Dog d)
        {
            d.Age++;
        }
    }

    class Dog
    {
        public int Age { get; set; }
    }
}

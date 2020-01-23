using System;
using System.Collections.Generic;
using System.Dynamic;

namespace lab_08_literal_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // dont do this
            var string1 = new String("some text");
            // instead we do
            String string2 = "some text";
            // array long way
            var array1 = new int[5]; // empty space
            var array2 = new int[] { 1, 2, 3, 4, 5 }; //literally defining items

            var list1 = new List<int>();
            var list2 = new List<int>() { 1,2,3,4,5};

            // random object
            dynamic object1 = new ExpandoObject();
            object1.name = "Joe";
            object1.age = 22;
            object1.balance = 25.8;

            Console.WriteLine($"object1 has a name{ object1.name} and age {object1.age} with a balance of {object1.balance}");

            // another example

            var object2 = new
            {
                name = "fred",
                age = 22
            };
            Console.WriteLine($"{object2.name} is of age {object2.age}");

            //OOP Language : create new OBJECT using Literal Data
            var dog1 = new Dog()
            {
                dogName = "fido",
                dogAge = 22
            };
            Console.WriteLine($"{dog1.dogName} is {dog1.dogName} years old");
        }
    }

    class Dog
    {
        public string dogName;
        public int dogAge;
    }
}

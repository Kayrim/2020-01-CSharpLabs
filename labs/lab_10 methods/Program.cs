using System;

namespace lab_10_methods
{
    class Program
    {

        // MAIN METHOD! Starts the program!
        static void Main(string[] args)
        {
            //calling methods
            DoThis();
            DontDoThis();

            //declaring methods
            void DontDoThis()
            {
                Console.WriteLine("Dont do it like this");
            }

            var dog = new Dog();
            dog.name = "fido";
            dog.age = 2;
            dog.Grow();
            Console.WriteLine($"{dog.name} is now {dog.age} and has {Dog.numLegs} legs"); // numLegs is not inheritied because it is static to the Dog class
           
        }

        static void DoThis()
        {
            Console.WriteLine("Do this method");
        }
    }

    class Dog {
        public int age;
        public string name;
        public static int numLegs = 4;
        public Dog()
        {
            this.age = 0;
        }
        public void Grow()
        {
            this.age++;

        }
    }
}

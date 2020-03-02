using System;

namespace lab_10_methods
{
    class Program
    {
        // MAIN METHOD!  starts program!
        static void Main(string[] args)
        {
            // call it
            DoThis();
            DontDoThis();

            // declare it
            void DontDoThis()
            {
                Console.WriteLine("Don't Do This");
            }

            var Fido = new Dog();
            Fido.Name = "Fido";
            Fido.Grow();
            Fido.Grow();
            Fido.Grow();
            Fido.Grow();
            Console.WriteLine($"{Fido.Age} has {Dog.NumLegs} legs");
        }

        static void DoThis()
        {
            Console.WriteLine("I am doing this");
        }

                    void DontDoThis()
            {
                Console.WriteLine("Don't Do This");
            }

    }

    class Dog
    {
        public string Name;
        public int Age;
        public static int NumLegs = 4;

        public Dog()
        {
            this.Age = 0;
        }

        public void Grow()
        {
            this.Age++;
        }
    }
}

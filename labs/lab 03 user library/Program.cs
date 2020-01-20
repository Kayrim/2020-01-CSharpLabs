using System;
using lab_03_library_files;

namespace lab_03_user_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calls and uses the public classes and variables!");

            // OOP: New instance to talk to the class
            var instance = new MyClass();

            instance.DoubleUp(10);
            double a = instance.GravitationalConstant;
            Console.WriteLine(a +"\n"+ instance.DoubleUp(10));
            Console.WriteLine(MyClass.NaturalLogarithmE + "\n" + MyClass.AlsoTripleUp(10));

        }
    }
}

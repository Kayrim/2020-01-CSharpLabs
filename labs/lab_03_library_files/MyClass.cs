using System;

namespace lab_03_library_files
{

    // class is a container
    public class MyClass
    {
        // Method (function)
        public int DoubleUp(int number)
        {
            return 2 * number;
        }

        // field
        public double GravitationalConstant = 9.81;


        // STATIC EQUIVALENT : read directly from class
        public static int AlsoTripleUp(int number)
        {
            return 3 * number;
        }
        // field
        public static double NaturalLogarithmE = 2.71;



    }
}

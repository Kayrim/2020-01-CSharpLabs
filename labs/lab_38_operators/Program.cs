using System;
using System.Collections;

namespace lab_38_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unary 

            // Increment ++ or --

            // Be very WARY OF THIS OPERATOR
            // SAFE RULE !!!  ALWAYS JUST USE IT ON STANDALONE LINE

            int x = 10;

            
            //  y = x first ie y = 10, then increment x to 11  
            int y = x++;              // y 10    x 11

            Console.WriteLine($"x is {x}, y is {y}");

            // z =   (( increment y first from 10 to 11) ie z = 11
            int z = ++y;              // z 11

            // What are the values of y and z?

            Console.WriteLine($"x is {x}, y is {y} and z is {z}");


            // ! not operator
            var isValid = false;
            isValid = !isValid;   // flip boolean
            Console.WriteLine(isValid);  // true


            // Binary operators

            // BODMAS / BIDMAS


            // MODULUS = REMAINDER

            //  can easily separation fractional parts
            //  3   4/5
            // 19/5
            int a = 19;
            int b = 5;
            Console.WriteLine(a/b);  // integer division
                                     // truncates

            Console.WriteLine(a%b);  // fractional part ie remainder
                                     // of division  ie 3 remainder 4

            // one input must be decimal for output to be decimal

            int c = 19;
            double d = 5.0;   // affect output
            Console.WriteLine(c/d);  // accurate decimal

            // && AND and || OR

            // short circuit !!!

            if (false && false) { }  // will not check second operator

            if (true || true) { }    // will not check second operator

            if (true ^ false) { }    // XOR  will return true

            if (true ^ true) { }     //                  false


            // TERNARY OPERATOR

            if (1 == 1) { }
            else { }

            // replace with

            var output = (1 == 1) ? DoThis() : "output this if false";

            string DoThis() { return "do this if true";  }



        }
    }

    //class test : IEnumerable {
    //    // must implement GetEnumerator
    //    int GetEnumerator() { return -1; }
    //}


}

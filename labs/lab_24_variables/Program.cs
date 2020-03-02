using System;
using System.Collections.Generic;

namespace lab_24_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            num1 = -100;
            uint num2 = 200;
            // num2 = -200;  not allowed

            // decimals
            // float
            var num3 = 200.0f;    // 32 bits
            // double
            var num4 = 200.0;   // default : 64 bits long (use this!)
            // decimal
            var num5 = 200.0m;   // 128 bits precision (use for money!)


            // OVERFLOW
            // Care!!! INTEGERS WILL TAKE WRONG VALUE!
            //         DECIMALS WILL TRUNCATE
            // INTEGERS
            int bigNumber = int.MaxValue;   // 2 billion
            Console.WriteLine(bigNumber);
            bigNumber = bigNumber * 10;
            Console.WriteLine(bigNumber); // CARE!  
            checked
            {
                // check for big numbers (not on by default!)
            }

            // DECIMALS - THEY TRUNCATE!
            double num6 = 1.23456789012345678901234567890123456789012345678901;
            Console.WriteLine($"long number prints as {num6}");

            // EXPONENTIAL VALUES
            Console.WriteLine($"Max double value is {double.MaxValue}");    // 10^300

            // CARE WITH DECIMAL EQUIVALENTS
            double num7 = 0.1;
            double num8 = 0.2;
            if (num7 + num8 == 0.3)      Console.WriteLine("numbers match"); 
            Console.WriteLine(num7+num8);

            // 0.1 ie decimals are stored non-precisely in binary
            if (Math.Abs(num8 - num7) < 0.00001) Console.WriteLine("Numbers match to 5DP");


            // char
            char char01 = 'f';   // Single quote
            Console.WriteLine(char01);        // f
            Console.WriteLine((int)char01);   // ASCII NUMBER  102
            // other way
            Console.WriteLine((char)103);      // wow!  ASCII 103 ==> character g

            // string
            // string is ARRAY OF CHARS
            string myName = "Phil";
            Console.WriteLine(myName[1]);   // h
            // all 
            foreach (char c in myName) { Console.WriteLine(c); }
            for (int i = 0; i < myName.Length; i++)
            {
                Console.WriteLine(myName[i]);
            }

            // bit   1/0
            bool isAwake = true;


            // byte
            // 8 bits
            byte byte01 = 0;   // min
            byte byte02 = 255; //  max     numbers RGB RED GREEN BLUE (10,20,30)
            byte byte03 = 0b_1010_1010;     // BINARY LITERAL  1010 represents decimal 10 hex A
            byte byte04 = 0xAA;   // 0x - WHAT FOLLOWS IS HEX
            byte byte05 = 0x10;   // 0x - WHAT FOLLOWS IS HEX  (DECIMAL 16)


            // create a LITERAL
            var myItem = new
            {
                name="Fred",
                id=22
            };

            Console.WriteLine($"{myItem.name} has id {myItem.id}");

            // literal array
            var myArray = new int[] { 1, 2, 3, 4, 5 };
            // more work
            var myArray2 = new int[20];
            myArray2[0] = 1;
            var myList = new List<string>() { "a", "b", "c" };

            // good
            string string01 = "hi";
            // not so good
            string string02 = new String("hi"); // too much

            char[] string03 = "literal string".ToCharArray();

        }
    }
}

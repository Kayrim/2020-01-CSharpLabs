using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                ## Operators
                Code out x++ and ++x - what is the difference? 
                Display this in code.
           */


            /*
            ## Loops
            Code out a loop with the `break` keyword
            Code out a loop with the `continue` keyword
            Code out a `switch` statement
            */

        }
    }







    public class Basic_Tests
    {
        /*
            Build a 2D array and put numbers in it using a nested loop

                for(int i=0;i<10;i++){
                    for(int j=0;j<10;j++){

                    }
                }

            Return the sum of all the integers
            if i = 2 and j=2 then values are 0,1 and 0,1 so sum = 0+1+0+1=2
            */
        public int Test_100_Sum_2D_Array(int i, int j)
        {
            return -1;
        }


        /*
        ### Fill a 3D Cube and return the sum of all the numbers
        Build a 3D Grid Array and put numbers in it using a triple nested loop
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++){
                for (int k=0;k<10;k++){
                }
            }
        }
        */

        public int Test_120_Sum_3D_Cube(int i, int j, int k)
        {
            return -1;
        }

        /*
        Build an array which takes as an input parameter the size of the array.
        The array items are the square of the index
        Build the array
        Create a test to return the sum
        Sample data : size = 10 then output = 285
        Sample data : size = 20 then output = 2470

        */

        public int Test_125_Build_Array_And_Return_Sum_Of_Squares(int arraySize)
        {
            return -1;
        }



        /* 
        Pass in array   [10,11,15,25..
        While loop ==> add one to each number  [11,12,16
        Do..While loop ==> add 3 to each number  [14,15,19..
        Foreach loop ==> double each number  [28,30,38...
        Return the total
        */

        public int Test_126_Loops(int[] array)
        {
            return -1;
        }








        // return (x + y/z) observing BIDMAS rules
        public double Test_130_BIDMAS(int x, int y, int z)
        {
            return -1.0;
        }


        /* 
         Create a BIDMAS test to test if the operations 
         are being carried out successfully
         What is ( (a+b*c/d-e) / f ) to the power n ?
         Code 2 examples with real numbers
         */
        public double Test_140_BIDMAS(int a, int b, int c, int d, int e, int f)
        {
            return -1;
        }


        public int Test_150_Return_Integer_Of_Char(char c)
        {
            return -1;
        }


        // Goal : Return ASCII number of character sent in
        // Input a string eg "hello" and an index eg 3
        // Return ASCII number of letter 'l' as number 108 
        public int Test_160_ASCII_Return_Index_Of_String(string input, int index)
        {
            return -1;
        }



        /*
         Test to add up the total ASCII values of 
         a string including any spaces!
         */

        public int Test_170_Sum_ASCII_Values_Of_String(string s)
        {
            return -1;
        }

        // Test to add up the total ASCII values of a string
        // minus any spaces!
        public int Test_180_Sum_ASCII_Values_Of_String(string s)
        {
            return -1;
        }


        // # Methods :   Multiply 2 Numbers And Raise To Power
        // 2, 3, 3  ==> (2*3)=6 and raise this to power 3 ie 36*6=216

        public double Test_200_Methods(double x, double y, int p)
        {

            Console.WriteLine($"Here is some data {x} {y} {p}");
            return Math.Pow((x * y), p);
        }


        // Divisors
        // how many integers are divisible by given divisor in the given range?
        // example (2,10,4) means start at 2 and count up to 10
        // only 4 and 8 are divisible by 4
        // so answer is 2
        public static int Test_210_How_Many_Numbers_Divisible_By(int start, int end, int divisor)
        {
            return -1;
        }



        /*
         # List Queue Stack
            Pass in an integer array
            Iterate over the array, double each number and put in a LIST
            Iterate over LIST and square every item and put into QUEUE
            Iterate over QUEUE and cube every item and put into STACK
            Sum items in STACK 
            Return sum
         */
        public int Lab_250_Return_Sum_Of_List_Queue_Stack(int[] inputArray)
        {
            return -1;
        }



        /*
           Input numbers and put into an ArrayList
           Create an Array, List, Queue, Stack, Dictionary.
           Move objects from Arraylist to each item and multiply each number by 4 each move.
           What's the total? 
        */

        public int Lab_260_ArrayList_Array_List_Queue_Stack_Dictionary(int[] inputArray)
        {
            return -1;
        }


        /*
        Iterate over the array, extract the numbers, 
           square the numbers, and add to a List
        Iterate over the list, subtract 10, add to a Dictionary<int, int>
        Iterate over dictionary and return sum
         */
        public static int Lab_270_Array_List_Dictionary_Get_Total(int[] inputArray)
        {
            return -1;
        }





        // STRINGS //

        // takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        // Hello => hElLo first character should be a lowercase
        public string TextToSpongeBobMeme(string str)
        {

            return "";
        }

        // takes 3 words, return a string removing the middle word leaving one space
        public string RemoveMiddleWord(string str)
        {

            return "";
        }

        // takes an array of ints, return the sum of the array NOT INCLUDING THE LARGEST NUMBER
        public int SumIgnoringMax(int[] intArr)
        {

            return -1;
        }

        // takes 2 ints which decides how high the pyramid goes
        /*example for 5, 9

             *
            ***
           *****
          *******
         *********

        */
        public char[,] Pyramid(int height, int width)
        {
            char[,] pyramid = new char[height, width];
            //some code to make it work, good luck 

            return pyramid;
        }

        // takes 2 int arrays, returns the elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2)
        {

            return new int[] { };
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddAYear(int year, int month, int day)
        {
            return "";
        }
        // An Array of integers are provided theyre in a random order
        // create a method that will sort this array in an acsending order
        public int[] BubSort(int[] unsorted)
        {
            return new int[] { };
        }

        // Create a method that will write the string "Hello" reversed
        public string ReverseString(string str)
        {
            return str;
        }

        //solve 3x^2 + 2x - 1, one of the roots will be the correct answer
        public double Quadratic(int a, int b, int c)
        {
            return 0;
        }
        // get 5th letter from the words inputted not including spaces
        //if there aren't 5 letters return a whitespace char ' '
        public char FifthLetter(string test)
        {
            return ' ';
        }
        // create a loop, return the sum of all the multiples of 4. Also use out the sum of all that is not the multiple of 6.
        // return the sum of all of the multiples of 4, which aren't multiples of 6, up to the inputted number,
        public int SumOfFours(int test)
        {
            return -1;
        }
        // return true is the 4 characters make up a string that match a name in the array given
        public bool NameReturn(char a, char b, char c, char d)
        {
            bool isName = false;
            string[] names = new string[] { "chad", "jess", "adam" };

            return isName;
        }
        // Find the smallest integer in an array of integers
        public int Smallest(int[] intArray)
        {
            //Code here
            return -1;
        }

        // given a positive integer that is a squared number
        // find the next squared number eg 9 => 16
        public int NextSquare(int n)
        {
            // Code here
            return -1;
        }
        // Calculate the nth term in a geometric series , a_n
        // a_1 is the first term, r is the common ratio and n is the number of terms
        // Remember the first term a_1 is already given, that is, n = 1
        // Give your answer to 2d.p.
        public double GeometricSeries(int a_1, double r, int n)
        {
            // Code here
            return -1;
        }

        //Roman Encyption shift each letter in the string up by 13, it is still csae sensitive
        // "Hello" would become "Uryyb"
        public string RomanEncryption(string messge)
        {
            string code = "";
            return code;
        }

        //Decrypt the roman message
        //"Uryyb" would become "Hello"
        public string RomanDecryption(string code)
        {
            string message = "";
            return message;
        }

        // summation between the 2 numbers including numbers inputed given Sum(0,3) => 6 and Sum(3,-1) => 5
        public int Sum(int a, int b)
        {
            return -1;
        }


        // Pass in a sentence and return an array of individual words
        public static string[] Create_Array_From_Sentence(string sentence)
        {
            return new string[] { };
        }

        // Pass in a sentence and return the number of words
        public static int Calculate_Words_In_Sentence(string sentence)
        {
            return -1;
        }

        public static string Turn_First_Word_To_Uppercase(string sentence)
        {
            // "this is a sentence" returns "THIS is a sentence"
            return "";
        }

        public static string Turn_All_Words_To_Uppercase_But_Last_Word_To_Lowercase(string sentence)
        {
            // "this is a sentence" returns "THIS IS A sentence"
            return "";
        }




    }





















}
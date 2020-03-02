using System;

namespace lab_32_variables_final
{
    class Program
    {

        // readonly IN CLASS FIELD
        readonly public static double PII = 3.1415;
        // PROERTY - USE GET NOT SET // SET WITH CONSTRUCTOR BUT AT NO OTHER TIME
        public DateTime DateOfBirth { get; }


        static void Main(string[] args)
        {
            // const
            const double PI = 3.1415;

            var p = new Parent();
            //p.DateOfBirth = DateTime.Now;
            Console.WriteLine(p.DateOfBirth);


            // null
            var emptyString = "";      // box for data but nothing in the box
            string nullString = null;  // points to 'null' element
            Console.WriteLine($"Is an empty string null?  {emptyString == nullString}");


            // null coalesce
            // IF....is null ... do this ... else ... do this
            string databaseItem = null;
            string myItem = databaseItem ?? "invalid value";
            Console.WriteLine(myItem);  // invalid value

            databaseItem = "real item";
            myItem = databaseItem ?? "invalid value";
            Console.WriteLine(myItem);  // real item

            databaseItem = null;
            // can't take length of null so will throw excpetion
            //Console.WriteLine(databaseItem.Length);
            // null check
            Console.WriteLine(databaseItem?.Length);  // SAFELY RETURNS NULL 


            // CASTING AND BOXING
            // Casting from ONE TYPE TO ANOTHER
            // EXPLICIT () 
            double num01 = 1.23;
            int integer01 = (int)num01;   // CAST IS A DANGEROUS OPERATION ==> CUT / TRUNCATE DATA
            Console.WriteLine($"{num01} becomes {integer01}");

            // OK from int to double 1 ==> 1.0 SAFELY
            // IMPLICIT 
            int integer02 = 12;
            double num02 = integer02; // 12.0

            // BOXING JUST CASTS TO GENERAL OBJECT
            var item01 = 12;
            var item02 = "hi";
            var object01 = (object)item01;
            var object02 = (object)item02;
            // OBJECT IS PARENT OF ALL PARENTS IE TOP OF COMPUTER HIERARCHY
            var getMyItemBack = (int)object01;


            // nullable type
            // INTEGERS CANNOT BE NULL!
            // BOOLEANS CANNOT BE NULL!
            // DOUBLES CANNOT BE NULL!
            int num03 = default;  // 0 (not null)
            // database NUMBER WHICH IS BLANK ==> 0 ???  INCORRECT AS IT'S A VALUE
            int? databaseNumber = null;
            bool? databaseIsAlive = null;
            double? databasePrice = null;
        }
    }

    class Parent
    {
        public DateTime DateOfBirth { get; }
        public Parent()
        {
            this.DateOfBirth = DateTime.Today;
        }
    }


}

using System;

namespace lab_33_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(); // Action method, Sends no Parameters, Returns nothing
            string stuff = AlsoDoThis();
            string moarStuff;
            string moreStuff = AnotherThis(out moarStuff);

            Console.WriteLine(moarStuff);
        }

        static string AnotherThis( out string output3)
        {
            output3 = "OMG Moarrrr";
            return "More stringssss";
        }
        static string AlsoDoThis()
        {
            return "I am also stuff";
        }
        static void DoThis() 
        {
            Console.WriteLine("Stuff if doing");
        }
    }
}

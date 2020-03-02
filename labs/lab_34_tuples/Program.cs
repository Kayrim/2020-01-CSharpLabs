using System;

namespace lab_34_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(); // ACTION IE SENDS NO PARAMETERS, RETURNS NOTHING
            string output = AlsoDoThis();

            string output3;
            int output4;
            string output2 = AndThisAlso(out output3, out output4);

            var output5 = FinallyThis();
            Console.WriteLine(output5.Item1);
            Console.WriteLine(output5.Item2);
            Console.WriteLine(output5.output6);
            Console.WriteLine(output5.output7);
            output5.output7 += 5000;
        }

        static void DoThis() { Console.WriteLine("I am doing This"); }
        static string AlsoDoThis() { return "I am also doing this"; }
        static string AndThisAlso(out string output3, out int output4) {
            output3 = "Even this as well";
            output4 = 100;
            return "And this also"; 
        }

        // TUPLES ARE ANONYMOUS OBJECTS 
        static (string output6 ,int output7) FinallyThis() { 
            return ("Finally this",2000); 
        }




    }
}

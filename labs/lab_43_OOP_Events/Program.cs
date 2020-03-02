using System;

namespace lab_42_events
{
    class Program
    {

        public delegate string MyDelegate(string x, string y);
        public static event MyDelegate MyEvent;

        static void Main()
        {
            // ADD METHODS
            MyEvent += DoThis;
            MyEvent += DoThat;
            MyEvent += DoThis;


            // NOTHING HAPPENS YET
            // TRIGGER
            Console.WriteLine(MyEvent("Fred", "Flintstone"));

        }

        static string DoThis(string a, string b)
        {
            return "Hello " + a + " " + b;
        }
        static string DoThat(string a, string b)
        {
            return "Goodbye " + a + " " + b;
        }
    }
}

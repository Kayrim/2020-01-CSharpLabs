using System;

namespace lab_40_events
{
    class Program
    {
        public delegate string MyDel(string x, string y);
        public static event MyDel MyEve;
        static void Main(string[] args)
        {
            // Add Methods
            MyEve += DoThis;
            MyEve += DoThat;

            //Trigger
            MyEve("Karim", "Bakkali");

            Console.WriteLine(MyEve("Karim", "Bakkali"));

        }
        static string DoThis(string a, string b)
        {
            return "Hey " + a + " " + b;
        }
        static string DoThat(string a, string b)
        {
            return "Later " + a + " " + b;
        }
    }
}

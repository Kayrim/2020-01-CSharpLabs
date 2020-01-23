using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Diagnostics;

namespace lab_11_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis();
            DoThis(80);
            DoThis("Hey");
            DoThis(20," Woo ",false, DateTime.Today);
            DoThis(20," Woo ",false, DateTime.Today,10,20);// setting the optional components
            DoThis(x:5,y:"Yo", z:true,time:DateTime.Now);
            DoThis(y:"Lost",x:10, z:true,time:DateTime.Now);

        }

        //overloading methods : same name different parameters
        static void DoThis()
        {
            Console.WriteLine("No Parameters");
        }

        static void DoThis(int x)
        {
            Console.WriteLine($"Integer {x}");
        }

        static void DoThis(string y)
        {
            Console.WriteLine($"String {y}");
        }

        static void DoThis(int x, string y, bool z, DateTime time)
        {
            Console.WriteLine($"{x}{y}{z}{time}");
        }
        static void DoThis(int x, string y, bool z, DateTime time, int opt1 = 1, int opt2 = 2) //declaring the default components - has to be at end
        {
            string output = $"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-10}{opt2,-10}";
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-10}{opt2,-10}");
            // saving to a text file
            File.AppendAllText("output.txt",output);
            // saving to a csv file
            string csvoutput = $"{x,-5},{y,-5},{z,-10},{time,-25},{opt1,-10},{opt2,-10}";
            File.AppendAllText("output.csv", csvoutput);
            // view as spreadsheet
            Process.Start("excel", "output.csv");
        }
    }
}

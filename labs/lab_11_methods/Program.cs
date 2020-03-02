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
            DoThis(100);
            DoThis("hi");
            DoThis(100, "hi", true, DateTime.Now);
            DoThis(100, "hi", true, DateTime.Now,10000,10000);  // set optional components
            DoThis(x: 100, y: "hi", z: true, DateTime.Now); // named parameters
            DoThis(z: true, y: "hi", x: 100, time:DateTime.Now,opt1:10000); // named parameters

        }

        // overloading methods : same name different parameters
        static void DoThis() { Console.WriteLine("No parameters"); }
        static void DoThis(int x) { Console.WriteLine($"Integer {x}"); }
        static void DoThis(string y) { Console.WriteLine($"String {y}"); }

        static void DoThis(int x, string y, bool z, DateTime time) {
            Console.WriteLine($"{x}{y}{z}{time}");
        }
        static void DoThis(int x, string y, bool z, DateTime time,int opt1 = 1000,int opt2=1000)
        {
            // erase file
            File.Delete("output.txt");
            File.Delete("output.csv");
            string output = $"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}";
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}\n");
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}\n");
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}\n");
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}\n");
            Console.WriteLine($"{x,-5}{y,-5}{z,-10}{time,-25}{opt1,-15}{opt2}\n");
            // save as text
            File.AppendAllText("output.txt", output);
            // save as CSV which is COMMA SEPARATED VALUES
            string csvoutput = $"{x,-5},{y,-5},{z,-10},{time,-25},{opt1,-15},{opt2}\n";
            File.AppendAllText("output.csv", csvoutput);
            File.AppendAllText("output.csv", csvoutput);
            File.AppendAllText("output.csv", csvoutput);
            // view as spreadsheet
            Process.Start("Excel", "output.csv");


        }
    }
}

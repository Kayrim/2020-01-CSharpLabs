using System;

namespace lab_52_pass_by_reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nFirst Run - Integer Is Privately Handled Inside Method\n\n");
            int x = 10;
            DoThis(x);
            Console.WriteLine($"x is {x}");
            // PASS IN AN INTEGER BUT TRACK VALUE INSIDE METHOD
            // PASS BY REFERENCE
            Console.WriteLine($"\n\nSecond Run - Track integer inside method (PASS BY REFERENCE)\n");
            TrackThis(ref x); // move storage of x onto HEAP : PERMANENT TRACKING
            Console.WriteLine($"IN MAIN METHOD x is {x}");  // 1010
        }
        // PRIVATE USE OF X IE UNRELATED TO X PASSED IN
        static void DoThis(int x) {
            x = x + 10;
            Console.WriteLine($"x is {x}");
        }
        static void TrackThis(ref int x)
        {
            x += 1000;
            Console.WriteLine($"INSIDE METHOD x is {x}");  // 1010
        }

    }
}

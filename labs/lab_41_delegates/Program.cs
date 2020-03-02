using System;

namespace lab_41_delegates
{
    class Program
    {
        public delegate void Delegate01();
        public delegate void Delegate03(int x, int y);
        static void Main(string[] args)
        {
            // var delegate01 = new Delegate();

            var delegate02 = new Delegate01(Method01);
            delegate02 += Method02;
            delegate02 += Method03;
            // NOTHING IS RUNNING!!!
            // TO RUN , CAN CALL DELEGATE WITH BRACKETS
            delegate02();

            var delegate03 = new Delegate03(Method04);
            delegate03(10,100);

            // MOST COMMON DELEGATE TYPE IS TYPE OF void MyDelegate();  
            // IE NO INPUTS, NO OUTPUTS  ==> ACTION DELEGATE!!!
            var delegate04 = new Action(Method01);
            // often see word 'Action()' in code ==> POINTER TO METHOD TYPES OF Void DoThis();

        }

        static void Method01() {
            Console.WriteLine("In Method01");
        }
        static void Method02()
        {
            Console.WriteLine("In Method02");
        }
        static void Method03()
        {
            Console.WriteLine("In Method03");
        }
        static void Method04(int x, int y)
        {
            Console.WriteLine($"Method 04 inputs {x} and {y}");
        }
    }
}

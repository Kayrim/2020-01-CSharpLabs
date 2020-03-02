using System;
using System.Collections;

namespace lab_39_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface ILawnmower {
        void MowLawn();
    }

    interface ITool02 { }

    interface IEveryoneUsesThis {
        void EveryoneDoesThis();
    }


    class Parent : IEveryoneUsesThis {
        public virtual void EveryoneDoesThis() { }
    }

    // CHILD INHERITS FROM ONE PARENT ONLY BUT IMPLEMENTS (USES) MANY TOOLS/PLUGINS
    class Child : Parent, ILawnmower, ITool02 {
        public void MowLawn() { Console.WriteLine("Child is now mowing lawn safely"); }
    }


}

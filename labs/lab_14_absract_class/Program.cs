using System;

namespace lab_14_absract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //var abstractHoliday = new Holiday();    // abstract class : CODE MISSING 
            var realHoliday = new ActuallyGo();
            realHoliday.BookHotel();
            realHoliday.GetMoney();
            realHoliday.GetThere();
            realHoliday.VisitNamibia();    //  concrete class ie ALL CODE COMPLETE
        }
    }

    // cannot INSTANTIATE THIS CLASS (IE CANNOT CREATE INSTANCES OF NEW HOLIDAY YET)
    abstract class Holiday
    {
        public abstract void GetThere();

        public abstract void BookHotel();

        public void VisitNamibia() { Console.WriteLine("We know where we are going"); }

        public void GetMoney() { Console.WriteLine("Yep, got the funds"); }
                             // { ...... CODE BODY OR IMPLEMENTATION      }
    }

    // THIS IS A CONCRETE CLASS BECAUSE CAN CREATE NEW INSTANCES AND ACTUALLY GO ON HOLIDAY
    class ActuallyGo : Holiday
    {
        public override void GetThere() { Console.WriteLine("Fly then drive"); }

        public override void BookHotel() { Console.WriteLine("In Lion Village"); }
    }




}

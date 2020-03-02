using System;

namespace lab_09_OOP_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CreateGenericCar
            // var keyword INFER TYPE FROM RIGHT ie CAR
            // car01 INSTANCE ie particular object created
            // Car = TEMPLATE USED
            // () run a METHOD when calling 'new' keyword  //  Constructor Method
            var car01 = new Car();
            car01.Make = "Mercedes";
            for (int i = 0; i< 1000; i++)
            {
                // CREATE 1000 CARS!
                var car = new Car();
            }
            var newCar = new Car();
            Console.WriteLine($"Initial Speed {newCar.Speed}");
            newCar.Speed++;
            newCar.Speed++;
            Console.WriteLine($"Final Speed{newCar.Speed}");
            var car02 = new Car("Mercedes","C220","silver",2200);
            #endregion CreateGenericCar
            #region CreateS220Car
            var s220car01 = new S220();  // constructors NOT INHERITED
            var car04 = new S220("blue", 2200);
            Console.WriteLine($"new car {car04.Make} {car04.Model} is {car04.Color} ");
            #endregion CreateS220Car
        }
    }

    #region Classes
    class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int Length; // mm
        public int Speed;

        // Constructor is present even if not stated
        // Default constructor
        public Car() {
            this.Speed = 0;  // THIS KEYWORD refers to INSTANCE OBJECT IN USE AT THE TIME
        }

        public Car(string make, string model, string color, int length)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Length = length;
            this.Speed = 0;
        }

    }

    class Mercedes : Car { }

    class SClass : Mercedes {
        public bool sportsModel;
        public bool leatherSeats;
        public string Make = "Mercedes";
    }

    class S220 : SClass { 
        public S220(string color, int length)
        {
            //Make = "Mercedes";
            Model = "S220";
            Color = color;
            Length = length;
            Speed = 0;
        }
        public S220() { }
    }

    #endregion

}

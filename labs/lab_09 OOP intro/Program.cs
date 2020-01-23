using System;

namespace lab_09_OOP_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GenericCar
            // var keywrod will INFER the TYPE from RIGHT ie CAR
            // car1 is the instance
            // CAR is the template
            // () run a Method when calling 'new' keyword // CONSTRUCTOR METHOD
            var car1 = new Car();
            car1.Make = "BMW";

            for (int i = 0; i < 100; i++)
            {
                //Makes 100 Cars
                var car = new Car();
            }

            var car3 = new Car("Mercedes", "A300");
            #endregion

            #region CreateS220CAR
            var s220v1 = new S220();// Constructor is not inherited




            #endregion
        }
    }

    #region Classes
    class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int Length; //mm
        public int Speed;

        // CONSTRUCTOR is present even if not state : Default 
        public Car()
        {
            this.Speed = 0; //This keyword refers to the instance in use

        }

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
    }

    class Mercedes : Car { }

    class Sline : Mercedes {
        public bool sportsModel;
        public bool leatherSeats;
    }

    class S220 : Sline { }

    #endregion
}

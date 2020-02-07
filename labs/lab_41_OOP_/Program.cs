using System;

namespace lab_41_OOP_events
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child("Wilma");

            c.Grow();
            c.Grow();
            c.Grow();
            Console.WriteLine($"Child is now {c.Age}");
        }
    }
    class Child
    {
        delegate void BirthdayDel();

        event BirthdayDel BirthdayEve;

        public string Name { get; set; }
        
        public int Age { get; set; }

        public Child(string name)
        {
            Name = name;
            Age = 0;
            //initialise event by adding atleast one method.
            BirthdayEve += HaveBirthdayParty;
        }
        void HaveBirthdayParty()
        {
            Console.WriteLine($"Child is having a new Birthday");
            Age++;
        }
        public void Grow()
        {
            BirthdayEve();
        }
    }
}

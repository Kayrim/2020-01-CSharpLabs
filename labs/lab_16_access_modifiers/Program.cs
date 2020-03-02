using System;

namespace lab_16_access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            var c = new Child();

            // p._hidden ...
            p.Exposed = "Yes we can see this";
            c.Exposed = "Yes also visible";
            p.IsUserLive = true;
            c.IsUserLive = true;
            //  p.FamilyName ...

            // SOMEHOW CREATE AS MANY VARIABLES AS YOU CAN IN DIFFERENT WAYS THAT BOTH p and c CAN ACCESS
            var dog = new Dog();
            dog.Name = "GreatestPet";
            p.TakeForWalk(dog);
            c.TakeForWalk(dog);
            c.ChangeNameOfDog(dog, "I Like This Name Better");
            p.ChangeNameOfDog(dog, "Stick With Original");
            Console.WriteLine(dog.Name);
        }
    }

    class Dog { 
        public string Name { get; set; }

    }

    class Parent
    {
        private int _hidden;                 // ENCAPSULATION
        public string Exposed { get; set; }

        internal bool IsUserLive;            // VISIBLE INSIDE .EXE/DLL BUT NOT OUTSIDE IT

        protected string FamilyName { get; set; }        // VISIBLE INSIDE CHILD  

        public void TakeForWalk(Dog d) { Console.WriteLine($"Taking {d.Name} for a walk"); }
        public void ChangeNameOfDog(Dog dog, string newName) { dog.Name = newName; }
    }

    class Child : Parent
    {
        // CAN'T PUT CODE DIRECTLY IN CLASS

        // USE CONSTRUCTOR BUT COULD USE ANY METHOD

        public Child()
        {
            this.FamilyName = "Robertson";
        }
    }

}

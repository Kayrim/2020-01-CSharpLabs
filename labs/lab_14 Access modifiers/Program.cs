using System;

namespace lab_14_Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = new Child();
            
        }
    }

    class Parent
    {
        private int _hidden;    // Encapuslation

        public string Exposed { get; set; }

        internal bool isUserLive;  // Visible to program library but not outside it

        protected string familyName; // Visible to child classes
    }

    class Child : Parent 
    { 
    public Child()
        {
            this.familyName = "Adams";
        }
    }
}

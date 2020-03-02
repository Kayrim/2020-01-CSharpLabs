using System;

namespace lab_35_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Person();
            var p02 = new Person(10);   //OVERLOADED CONSTRUCTOR
            var p03 = new Person("Tasha");
            p02.Age++;
            p02.DoThis(c: 12, b: 15, a: 10, f: false, d: 22);
            p02.DoThis(c: 12, b: 15, a: 10, f: false, d: 22,g:"real value");
        }
    }

    class Person
    {
        // default constructor, hidden, with null values
        private int _age = -1;
        public string Name { get; set; }

        internal void DoThis(int a, int b, int c, int d, bool f, string g = "default")
        {

        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        public void SetAge(int newAge)
        {
            this._age = newAge;
        }

        public Person() { } // default
        public Person (int age)
        {
            this._age = age;
        }
        public Person(string name) {
            this.Name = name;
        }
        public Person(int age, string name)
        {
            this._age = age;
            this.Name = name;
        }

    }
}

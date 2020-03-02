using System;

namespace lab_12_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var user01 = new User("NT353637","AB");
            
            Console.WriteLine($"{user01.NINO}");
            user01.NINO = null;  // reset     null means 'no data present in field'    null is not ""
            user01.Age = -100;
            Console.WriteLine($"Age is now {user01.Age}");
            var user02 = new User("NR44444","AB");
            string updatedAge = "22";
            user02.Age = int.Parse(updatedAge);
            updatedAge = "something";
            // Fail user02.Age = int.Parse(updatedAge);
            int numericAge;
            int.TryParse("something", out numericAge);
            user02.Age = numericAge;
            Console.WriteLine(user02.Age);
            int? anyNumber = default;
            Console.WriteLine(anyNumber);

            Console.WriteLine(user02.Height);
            user02.Height = 2000;
            Console.WriteLine(user02.Height);
        }
    }




    class User
    {
        // FIELDS (PRIVATE)
        private string _NINO;
        private string _bloodType;
        private int _age;

        // CONSTRUCTOR

        public User(string nino,string bloodtype)
        {
            this._NINO = nino;
            this._bloodType = bloodtype;
        }

        // PROPERTY (PUBLIC, SHORT VERSION)
        public int Height { get; set; }   // Public property
        // public PROPERTY
        public string NINO
        {
            get { return this._NINO;  }
            set { this._NINO = value;  }    // value is a C# built-in carrier of the data from MAIN() TO INSTANCE.
        }

        public int Age
        {
            get { return this._age; }
            set {
                if (value >= 0)
                {
                    this._age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative");
                }
            }
        }

    }
}

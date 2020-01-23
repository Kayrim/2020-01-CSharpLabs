using System;

namespace lab_12_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("019", "1,000,000");
            Console.WriteLine(user1.Bank);
        }
    }

    class User
    {
        private string _Bank;
        private string _Balance;
        private int _Phone;

        public User(string bank, string balance)
        {
            this._Bank = bank;
            this._Balance = balance;
        }
        public int Phone { get; set; }

        public string Bank
        {
            get { return this._Bank; }
            set {
                if (value.Length >0)
                {
                    this._Bank = value;
                }// C# built in carrier of data from Main() to instance.
                else
                {
                    Console.WriteLine("insert your bank");
                }
            }
                

        }
    }
}

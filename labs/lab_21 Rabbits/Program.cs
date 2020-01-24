using System;
using System.Collections.Generic;

namespace lab_21_Rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            string[] names = { "joe" ,"jack", "tom","dick","harry","jamie","phil","kay","steven","alex"};

            var rabbits = new List<Rabbit>();
            for (int i = 0; i < 100; i++)
            {
                rabbits.Add(new Rabbit());
                rabbits[i].RabbitID = i;
            }
            
            rabbits.ForEach(x => x.Age = 0);
            rabbits.ForEach(x => x.name = names[rnd.Next(0,9)]);

            rabbits.ForEach(x => Console.WriteLine($"Rabbit {x.RabbitID} is called {x.name} and is {x.Age} years old"));
            for (int i = 0; i < 50; i++)
            {

                AgeRabbits(rabbits);

               
                    Console.WriteLine($"Rabbit {rabbits[i].RabbitID} is called {rabbits[i].name} and is {rabbits[i].Age} years old");
                
                
            }
            

            //rabbits.ForEach(x => Console.WriteLine($"Rabbit {x.RabbitID} is called {x.name} and is {x.Age} years old"));



            void AgeRabbits(List<Rabbit> x)
            {

                x.ForEach(i => i.Age++);
            }

        }
    }
    class Rabbit
    {
        public int RabbitID { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
    }
}

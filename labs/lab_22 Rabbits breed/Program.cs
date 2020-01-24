using System;
using System.Collections.Generic;

namespace lab_22_Rabbits_breed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rabbits can now produce a new rabbit once a year
            // Creating and initiating lists/objects/variables and the first rabbit - Chicken before the egg :)
            
            var rabbitList = new List<Rabbit>();
            rabbitList.Add(new Rabbit());
            rabbitList[0].Age = 0;
            rabbitList[0].RabbitID = 1;
            int totalRabits = 1;
            string[] names = { "Joe", "Jack", "Tom", "Dick", "Harry", "Jamie", "Phil", "Kay", "Steven", "Alex" };
            var rnd = new Random();



            // enter the amount of rabbits to breed (rounded to closes number that is 2^2
            Breed(rabbitList , 64);
            rabbitList.ForEach(x => x.name = names[rnd.Next(0, 9)]);
            rabbitList.ForEach(x => Console.WriteLine($"Rabbit {x.RabbitID} is called {x.name} and is {x.Age} years old"));


            void Breed(List<Rabbit> rabs , int input)
            {
                int rabbitsIn = rabs.Count;
                if (rabbitsIn < input)
                {
                    for (int i = 0; i <= rabbitsIn; i++)
                    {
                        ageRabbits(rabs);
                        foreach (var item in rabs.ToArray())
                            
                            {
                                
                                    rabs.Add(new Rabbit());
                                    rabs[totalRabits].RabbitID = totalRabits+1;
                                    rabs[totalRabits].Age = 0;
                                    totalRabits++;
                                
                            }
                        Breed(rabs, input);
                        break;
                        
                    }
                }
                else Console.WriteLine($"Rabbits have been neutered, too stop breeding at {totalRabits}");


            }
            void ageRabbits(List<Rabbit> rabs)
            {
                rabs.ForEach(x => x.Age++);
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

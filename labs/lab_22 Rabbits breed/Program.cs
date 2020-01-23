using System;
using System.Collections.Generic;

namespace lab_22_Rabbits_breed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rabbits can now produce a new rabbit once a year
            int totalRabits = 1;
            var rabbitList = new List<Rabbit>();
            rabbitList.Add(new Rabbit());
            rabbitList[0].Age = 0;
            rabbitList[0].RabbitID = 0;


            Breed(rabbitList);
            rabbitList.ForEach(x => Console.WriteLine($"Rabbit {x.RabbitID} and is {x.Age} years old"));


            void Breed(List<Rabbit> rabs)
            {
                int rabbitsIn = rabs.Count;
                if (rabbitsIn < 50)
                {
                    for (int i = 0; i <= rabbitsIn; i++)
                    {
                        ageRabbits(rabs);
                        foreach (var item in rabs.ToArray())
                            
                            {
                                
                                    rabs.Add(new Rabbit());
                                    rabs[totalRabits].RabbitID = totalRabits;
                                    rabs[totalRabits].Age = 0;
                                    totalRabits++;
                                
                            }
                        Breed(rabs);
                        if (totalRabits > 50)
                        {
                            break;
                        }
                    }
                }
                else Console.WriteLine("Too many RabbitS!!!!!");


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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; // query language  LANGUAGE INDEPENDENT QUERY
                   // use => LAMBDA ARROW

namespace lab_20_list_queue_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 10, 20, 30, 40 }; // LITERAL
            list.Add(50);
            list.Add(60); // at end
            list.Insert(0, 5);  // add 5 at index 0
            // print list
            // FOREACH...
            // foreach item in 'list'  (( get item, call it 'item, and process it whatever code in braces ))
            list.ForEach(item => { 
                Console.WriteLine(item);
            });

            var newList = list.Where(item => item > 30);

            list.Where(item => item > 30);


            // Queue
            var queue = new Queue<int>();
            // add 5 items to back of queue
            // remove 2 items
            // print queue

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);

            Console.WriteLine(queue.Dequeue()); 
            Console.WriteLine(queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(',', queue));
            Array.ForEach(queue.ToArray(), item => Console.WriteLine(item));

            // Stack
            // create stack with 10 random numbers (1 to 100)
            var random = new Random();
            random.Next(1, 100);

            var stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(random.Next(1,100));
            }


            // print stack on ONE LINE WITH COMMAS
            Console.WriteLine(string.Join(',' , stack));
            // remove top 3 items
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // print stack again
            Console.WriteLine(string.Join(',', stack));


            // Dictionary

            // Dictionary uses ORDERED SETS ie key is UNIQUE AND ORDERED, value is the data

            var dict = new Dictionary<int, string>();
            dict.Add(1, "hi");
            dict.Add(2, "there");
            dict.Add(3, "people");
            // error dict.Add(3,"anything");
            foreach(var item in dict)
            {
                Console.WriteLine($"Key {item.Key} has value {item.Value}");
            }


            // List of OBJECTS!!!
            // Sometimes we have to deal with collections of GENERIC OBJECTS
            var arraylist = new ArrayList();
            arraylist.Add(10);
            arraylist.Add("hi");
            arraylist.Add(new object());

            foreach(var item in arraylist)
            {

                Console.WriteLine($"Item {item} has type {item.GetType()}");
            }
            Console.WriteLine((int)arraylist[0]+100);
            Console.WriteLine((string)arraylist[1]+100);
            
        }
    }
}

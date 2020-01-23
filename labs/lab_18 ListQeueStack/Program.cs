using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab_18_ListQeueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            list.Add(6); // at end
            list.Insert(2, 100); // replace index 2 with 100
            foreach (var c in list) // for each item in the list print c
            {
                Console.WriteLine(c);
            }
            list.ForEach(x => { Console.WriteLine(x); }); // for each item in the list, call it x then process code eg, print x

            var newList = list.Where(x=> x>10);

            var queue = new Queue<int>();

            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Console.WriteLine(string.Join(",", queue));
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(string.Join(",", queue)); // using string.Join to make a string from whats left in the queue

            Array.ForEach(queue.ToArray(), x => Console.WriteLine(x)); // using lambda
            
            foreach (var item in queue)  // using for each 
            {
                Console.WriteLine(item);
            }
            var rnd = new Random();
            
            var stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                int oneToH = rnd.Next(1, 100);
                stack.Push(oneToH);
            }
            Array.ForEach(stack.ToArray(), x => Console.Write(x + ", "));
            Console.WriteLine("");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Array.ForEach(stack.ToArray(), x => Console.Write(x+", "));

            // Dictionary uses ORDERED SETS ie key is UNIQUE AND ORDERED, value is the data

            var dict = new Dictionary<int, string>();

            dict.Add(1, "hi");
            dict.Add(2, "there");
            dict.Add(3, "guys");

            foreach (var item in dict)
            {
                Console.WriteLine($"Key is {item.Key} and the value is {item.Value}");
            }

            // List of Objects
            // Sometimes we have to deal with collections of generic objects

            var arrr = new ArrayList();
            arrr.Add(10);
            arrr.Add("String");
            arrr.Add(new object());

            foreach (var item in arrr)
            {
                Console.WriteLine($"Item {item} and this is the type {item.GetType()}");
            }


            // ArrayList: ANY TYPE ANY SIZE 
            // Array: FIXED TYPE AND SIZE


            

        }
    }
}

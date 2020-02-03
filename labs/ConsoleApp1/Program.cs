using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 1, 2, 3, 4, 4, 5, 5, 5 };
            var nList = new List<int>();
            for (int i = 0; i < numArray.Length; i++)
            {
                if (nList.Contains(numArray[i]) == false)
                {
                    nList.Add(numArray[i]);
                }
            }
            var numNew = nList.ToArray();

            Console.WriteLine(numNew);
        }
    }
}

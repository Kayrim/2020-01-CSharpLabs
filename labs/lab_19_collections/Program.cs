using System;
using System.Linq;

namespace lab_19_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 1D Array from 0 to 9
            var array1D = new int[10];
            // fill the array with the appropriate number 0 to 9
            for(int i = 0; i < 10; i++)
            {
                array1D[i] = i;
            }
            // iterate (foreach) and get total of all numbers
            Console.WriteLine(string.Join(',',array1D));
            int total1D = 0;
            foreach(var item in array1D)
            {
                total1D = +item;
            }
            Array.ForEach(array1D, item => Console.WriteLine(item) );

            // pro way
            int[] array1Dpro = Enumerable.Repeat(0, 10).ToArray();
            // repeat with 2D grid (size 10x10)


            // repeat with 3D cube  (size 10x10x10)

        }
    }
}

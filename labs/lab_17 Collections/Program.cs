using System;

namespace lab_17_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //create 1D array from 0-9, fill array with corresponding number, iterate the array and sum it all
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.Write(i+"\t");
            }
            int a=0;
            int[,] array2 = new int[10,10];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int x = 0; x < array2.GetLength(1); x++)
                {
                    
                    array2[i, x] = a;
                    Console.Write(array2[i,x]+"\t");
                    a++;
                }

            }
            int b = 0;
            int[,,] array3 = new int[10,10,10];
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int x = 0; x < array3.GetLength(1); x++)
                {
                    for (int y = 0; y < array3.GetLength(2); y++)
                    {
                        array3[i, x, y] = b;
                        Console.Write(array3[i, x, y ]+"\t");
                        b++;
                    }
                }
            }


        }
    }
}

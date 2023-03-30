using System;
using System.Collections.Generic;
using System.Text;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 15 };
            Console.WriteLine(Average(array));
        }

        static double Average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (double)sum / array.Length;
        }
    }
}

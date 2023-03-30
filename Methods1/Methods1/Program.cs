using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine(Sum(a, b));
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 3.8f;
            int roundedInt = Round(myFloat);
            Console.WriteLine(roundedInt);
        }

        static int Round(float f)
        {
            return (int)Math.Round(f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 7;
            bool isEven = IsEven(myNum);
            Console.WriteLine(isEven);
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0) {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

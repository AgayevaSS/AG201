using System;
using System.Collections.Generic;
using System.Text;

namespace Methods5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool logic;
            bool.TryParse(Console.ReadLine(), out logic);
            Console.WriteLine(BooleanToAnswer(logic));
        }

        static string BooleanToAnswer(bool logic)
        {
            return logic ? "Beli" : "Xeyir";
        }
    }
}

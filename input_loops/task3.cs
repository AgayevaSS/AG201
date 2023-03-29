using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        Console.ReadLine();
    }
}

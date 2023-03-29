using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        if (age >= 18)
        {
            Console.WriteLine("You are old enough to vote.");
        }
        else
        {
            Console.WriteLine("You are not old enough to vote.");
        }

        Console.ReadLine();
    }
}

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Split the string into an array of words
        string[] words = inputString.Split(' ');

        // Calculate the number of words and print to the console
        int wordCount = words.Length;
        Console.WriteLine("The input string contains {0} words.", wordCount);
    }
}

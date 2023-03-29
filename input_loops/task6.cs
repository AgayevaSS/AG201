using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Multiplication table for " + num + ":");
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}

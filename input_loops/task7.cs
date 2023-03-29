using System;

class Program {
    static void Main(string[] args) {
        string password = "mypassword";
        
        Console.Write("Enter password: ");
        string input = Console.ReadLine();
        
        while (input != password) {
            Console.WriteLine("Incorrect password. Try again.");
            Console.Write("Enter password: ");
            input = Console.ReadLine();
        }
        
        Console.WriteLine("Correct password!");
    }
}

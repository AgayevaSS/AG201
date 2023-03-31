namespace task4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int integerResult))
        {
            Console.WriteLine("Input is an integer: " + integerResult);
        }
        else if (double.TryParse(input, out double doubleResult))
        {
            Console.WriteLine("Input is a double: " + doubleResult);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

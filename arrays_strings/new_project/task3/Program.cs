namespace task3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: "); // prompt the user to enter a sentence
        string sentence = Console.ReadLine(); // read the sentence entered by the user

        string[] words = sentence.Split(' '); // split the sentence into words

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            words[i] = char.ToUpper(word[0]) + word.Substring(1); // capitalize the first letter of each word
        }

        string modifiedSentence = string.Join(' ', words); // join the modified words into a sentence

        Console.WriteLine("Modified sentence: " + modifiedSentence); // output the modified sentence
    }
}

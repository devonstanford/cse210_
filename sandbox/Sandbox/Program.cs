using System;

class Program
{
    static void Main(string[] args)
    {
        string adjective = GetAdjective();
        string noun = GetNoun();

        Console.WriteLine($"I looked out the window and saw a {adjective} {noun}.");
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    static string GetAdjective()
    {
        Console.WriteLine("Enter an adjective:");
        string adjective = Console.ReadLine();
        return adjective;
    }

    static string GetNoun()
    {
        Console.WriteLine("Enter a noun:");
        string noun = Console.ReadLine();
        return noun;
    }
}
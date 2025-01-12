using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string suffix = "";
        int oneGrade = grade % 10;

        if (letter != "F" && letter != "A" && oneGrade >=7)
        {
            suffix = "+";
        }
        else if (letter != "F" && oneGrade <3)
        {
            suffix = "-";
        }

        Console.WriteLine($"You scored: {letter}{suffix}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        bool runStill = true;
        
        while (runStill)
        {
            MainMenu();
            string input = Console.ReadLine();
            if (input == "1")
            {
                MemorizeNewVerse();
            }
            else if (input == "2")
            {
                MemorizeJohn316();
            }
            else if (input == "exit")
            {
                runStill = false;
            }
        }
    }

    static void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorization Tool!");
        Console.WriteLine("Choose an option to continue or type 'exit' to quit.");
        Console.WriteLine("1. Memorize a new verse");
        Console.WriteLine("2. Memorise John 3:16");
    }

    static void MemorizeNewVerse()
    {
        Console.Clear();
        Console.WriteLine("Enter the reference for the verse you want to memorize.");
        string referenceText = Console.ReadLine();
        Console.WriteLine("Enter the verse you want to memorize.");
        string verseText = Console.ReadLine();
        Reference reference = new Reference(referenceText);
        Scripture scripture = new Scripture(reference, verseText);

        MemorizeLoop(reference, scripture);
    }

    static void MemorizeJohn316()
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        MemorizeLoop(reference, scripture);
    }

    static void MemorizeLoop(Reference reference, Scripture scripture)
    {
        bool memorizeStill = true;

        while (memorizeStill)
        {
            Console.Clear();
            Console.Write(reference.GetDisplayContent()+"");
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'exit' to quit.");
            string input = Console.ReadLine();
            if (input == "exit")
            {
                memorizeStill = false;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}


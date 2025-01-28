using System;

class Program
{
    static void Main(string[] args)
    {
        Prompts myPrompts = new Prompts();

        bool keepRunning = true;

        while (keepRunning)
        {
            MainMenu();
            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                    break;
                case "2":
                    bool runPrompts = true;
                    while (runPrompts)
                    {
                        PromptMenu();
                        string promptChoice = Console.ReadLine();
                        switch (promptChoice)
                        {
                            case "1":
                                myPrompts.New();
                                break;
                            case "2":
                                myPrompts.Delete();
                                break;
                            case "3":
                                myPrompts.Display();
                                break;
                            case "4":
                                runPrompts = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    break;
                case "3":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void MainMenu()
    {
        Console.WriteLine("1. Entries");
        Console.WriteLine("2. Prompts");
        Console.WriteLine("3. Quit");
    }

    static void PromptMenu()
    {
        Console.WriteLine("1. Add a prompt");
        Console.WriteLine("2. Delete a prompt");
        Console.WriteLine("3. Display all prompts");
        Console.WriteLine("4. Quit");
    }
}
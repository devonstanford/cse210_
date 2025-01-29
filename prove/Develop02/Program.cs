using System;

class Program
{
    static void Main(string[] args)
    {
        Prompts myPrompts = new Prompts();
        Journal myJournal = new Journal("myJournal.txt"); // Create a new Journal object. Delete if ever add loading specific files.

        bool keepRunning = true;

        while (keepRunning)
        {
            MainMenu();
            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":
                    bool runEntries = true;
                    while (runEntries)
                    {
                        EntryMenu();
                        string entryChoice = Console.ReadLine();
                        switch (entryChoice)
                        {
                            case "1":
                                string prompt = myPrompts.Get();
                                myJournal.New(prompt);
                                break;
                            case "2":
                                myJournal.Delete();
                                break;
                            case "3":
                                myJournal.Display();
                                break;
                            case "4":
                                runEntries = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
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
                    myJournal.Save();
                    myPrompts.Save();
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
        Console.WriteLine("====================================");
        Console.WriteLine("Main Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Entries");
        Console.WriteLine("2. Prompts");
        Console.WriteLine("3. Save and Quit");
        Console.WriteLine("");
    }

    static void PromptMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Prompts Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Add a prompt");
        Console.WriteLine("2. Delete a prompt");
        Console.WriteLine("3. Display all prompts");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
    }

    static void EntryMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Entries Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Add an entry");
        Console.WriteLine("2. Delete an entry");
        Console.WriteLine("3. Display all entries");
        Console.WriteLine("4. Quit");
        Console.WriteLine("");
    }
}
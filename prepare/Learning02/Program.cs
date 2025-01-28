using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        Resume myResume = new Resume();

        while (keepRunning)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Job newJob = new Job();
                    Console.Write("Enter job title: ");
                    newJob.JobTitle = Console.ReadLine();
                    Console.Write("Enter company: ");
                    newJob.Company = Console.ReadLine();
                    Console.Write("Enter start year: ");
                    newJob.StartYear = int.Parse(Console.ReadLine());
                    Console.Write("Enter end year: ");
                    newJob.EndYear = int.Parse(Console.ReadLine());
                    myResume.Jobs.Add(newJob);
                    Console.WriteLine("Job added.");
                    break;
                case "2":
                    myResume.Display();
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

    static void DisplayMenu()
    {
        Console.WriteLine("1. Add new job");
        Console.WriteLine("2. Display resume");
        Console.WriteLine("3. Quit");
        Console.WriteLine();
    }
}
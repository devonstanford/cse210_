using System;
using System.Dynamic;
using System.Collections.Generic;

public class Prompts
{
    public List<string> _promptList { get; set; }
    public string _filename { get; set; }

    public Prompts()
    {
        _promptList = new List<string>();
        _filename = "prompts.txt";
        Load(_filename);
    }

    public string Get()
    {
        Random rand = new Random();
        int promptNumber = rand.Next(0, _promptList.Count);
        return _promptList[promptNumber];
    }

    public void New()
    {
        Console.Write("Enter a new prompt: ");
        string prompt = Console.ReadLine();
        Console.Write($"The new prompt is: {prompt}. Do you want to add it? (y/n)");
        string add = Console.ReadLine();
        if (add == "y")
        {
            _promptList.Add(prompt);
            Console.WriteLine("Prompt added.");
        }
        else
        {
            Console.WriteLine("Prompt not added.");
        }
    }

    public void Delete()
    {
        if (_promptList.Count == 0)
        {
            Console.WriteLine("There are no prompts to delete.");
            return;
        }

        Console.Write("Enter the prompt number you want to delete: ");
        string prompt = Console.ReadLine();

        if (int.TryParse(prompt, out int result) == false || result < 1 || result > _promptList.Count)
        {
            Console.WriteLine("Invalid prompt number.");
            return;
        }

        int intPrompt = int.Parse(prompt);
        Console.Write($"Thi prompt will be deleted: {_promptList[intPrompt-1]}. Do you want to delete it? (y/n)");
        string delete = Console.ReadLine();
        if (delete == "y")
        {
            _promptList.Remove(_promptList[intPrompt-1]);
            Console.WriteLine("Prompt deleted.");
        }
        else
        {
            Console.WriteLine("Prompt not deleted.");
        }
    }

    public void Display()
    {
        for (int i = 0; i < _promptList.Count; i++)
        {
            Console.WriteLine($"{i+1}: {_promptList[i]}");
        }
    }

    public void Load(string filename)
    {
        if (!System.IO.File.Exists(filename))
        {
            _promptList.Add("Who was the most interesting person I interacted with today?");
            _promptList.Add("What was the best part of my day?");
            _promptList.Add("How did I see the hand of the Lord in my life today?");
            _promptList.Add("What was the strongest emotion I felt today?");
            _promptList.Add("If I had one thing I could do over today, what would it be?");
            return;
        }

        Console.WriteLine($"Loading prompts from {filename}...");
        _promptList.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _promptList.Add(line);
        }
        Console.WriteLine("Prompts loaded.");
    }

    public void Save()
    {
        FileStream stream = new FileStream(_filename, FileMode.OpenOrCreate);

        Console.WriteLine($"Saving prompts to {_filename}...");
        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(stream))
        {
            foreach (string prompt in _promptList)
            {
                outputFile.WriteLine(prompt);
            }
        }
        Console.WriteLine("Prompts saved.");
    }
}
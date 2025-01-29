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
        Console.Write("Enter the prompt number you want to delete: ");
        int prompt = int.Parse(Console.ReadLine());
        Console.Write($"Thi prompt will be deleted: {_promptList[prompt-1]}. Do you want to delete it? (y/n)");
        string delete = Console.ReadLine();
        if (delete == "y")
        {
            _promptList.Remove(_promptList[prompt-1]);
            Console.WriteLine("Prompt deleted.");
        }
        if (delete == "n")
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
        Console.WriteLine($"Saving prompts to {_filename}...");
        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(_filename))
        {
            foreach (string prompt in _promptList)
            {
                outputFile.WriteLine(prompt);
            }
        }
        Console.WriteLine("Prompts saved.");
    }
}
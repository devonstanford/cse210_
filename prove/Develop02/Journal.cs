using System;
using System.IO.Enumeration;

class Journal
{
    public List<Entry> Entries { get; set; }
    public string _filename { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void Load(string filename)
    {
        Console.WriteLine($"Loading journal from {filename}...");
        _filename = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('~');
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            Entries.Add(entry);
        }
        Console.WriteLine("Journal loaded.");
    }

    public void Save()
    {
        if (_filename == null || !File.Exists(_filename))
        {
            Console.Write("Enter the file name to save: ");
            _filename = Console.ReadLine()+".txt";


        }

        FileStream stream = new FileStream(_filename, FileMode.OpenOrCreate);

        Console.WriteLine($"Saving journal to {_filename}...");
        using (StreamWriter outputFile = new StreamWriter(stream))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._response}");
            }
        }
        Console.WriteLine("Journal saved.");
    }

    public void Display()
    {
        for (int i = 0; i < Entries.Count; i++)
        {
            Entries[i].Display(i + 1);
        }
    }

    public void Delete()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("There are no entries to delete.");
            return;
        }

        Console.Write("Enter the entry number you want to delete: ");
        string entry = Console.ReadLine();

        if (int.TryParse(entry, out int result) == false || result < 1 || result > Entries.Count)
        {
            Console.WriteLine("Invalid entry number.");
            return;
        }
        
        int intEntry = int.Parse(entry);

        Console.WriteLine($"This entry will be deleted:{Entries[intEntry - 1]._response}.");
        Console.Write("Do you want to delete it? (y/n)");
        string delete = Console.ReadLine();
        if (delete == "y")
        {
            Entries.Remove(Entries[intEntry - 1]);
            Console.WriteLine("Entry deleted.");
        }
        else
        {
            Console.WriteLine("Entry not deleted.");
        }

    }

    public void New(string prompt)
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry._prompt = prompt;
        Console.WriteLine(entry._prompt);
        Console.WriteLine("");
        entry._response = Console.ReadLine();

        Console.WriteLine($"Would you like to add this entry? (y/n)");
        string add = Console.ReadLine();
        if (add == "y")
        {
            Entries.Add(entry);
            Console.WriteLine("Entry added.");
        }
        else
        {
            Console.WriteLine("Entry not added.");
        }
    }
}
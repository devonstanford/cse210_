using System;

public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }
}
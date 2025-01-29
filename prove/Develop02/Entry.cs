using System;

class Entry
{
    public string _response { get; set; }
    public string _prompt { get; set; }
    public string _date { get; set; }

    public void Display(int number)
    {
        Console.WriteLine($"====================================");
        Console.WriteLine($"{number}.");
        Console.WriteLine("");
        Console.WriteLine(_date);
        Console.WriteLine("");
        Console.WriteLine(_prompt);
        Console.WriteLine("");
        Console.WriteLine(_response);
        Console.WriteLine("");
    }
}
public class Person
{
    // Private fields help to encapsulate the data and protect it from being accessed directly from outside the class.
    // This allows for better control over the data and ensures that it can only be modified through the class's methods.
    private string _name;
    private int _age;

    // Constructor
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} - {_age}");
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAge(int age)
    {
        if (age >= 0)
        {
            _age = age;
        }
        else
        {
            _age = 0;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age;
    }
}
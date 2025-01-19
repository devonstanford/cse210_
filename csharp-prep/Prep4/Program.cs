using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, enter 0 when finished.");
        
        bool done = false;
        List<int> numbers = new List<int>();

        while (!done)
        {
            Console.Write("Enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                done = true;
            }
            else
            {
                numbers.Add(number);
            }
        }

        int sum = Sum(numbers);
        float average = Average(numbers);
        int max = Max(numbers);
        int min = smallestPositive(numbers);
        List<int> sorted = smallestToLargest(numbers);

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The max is: " + max);
        Console.WriteLine("The smallest positive number is: " + min);
        Console.WriteLine("The sorted list is:");
        foreach (int number in sorted)
        {
            Console.WriteLine(number);
        }
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static float Average(List<int> numbers)
    {
        float sum = (float) Sum(numbers);
        return sum / numbers.Count;
    }

    static int Max(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static int smallestPositive(List<int> numbers)
    {
        int min = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static List<int> smallestToLargest(List<int> numbers)
    {
        numbers.Sort();
        return numbers;
    }


}
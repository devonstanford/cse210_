using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();

        resume.Name = "Allison Rose";
        resume.Jobs = new List<Job>();

        Job job1 = new Job();
        job1.JobTitle = "Software Developer";
        job1.Company = "Microsoft";
        job1.StartYear = 2019;
        job1.EndYear = 2022;
        resume.Jobs.Add(job1);

        Job job2 = new Job();
        job2.JobTitle = "Manager";
        job2.Company = "Apple";
        job2.StartYear = 2022;
        job2.EndYear = 2023;
        resume.Jobs.Add(job2);

        resume.Display();
    }
}
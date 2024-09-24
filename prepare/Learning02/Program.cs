using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Tesla";
        job1._jobTitle = "Technician";
        job1._startYear = 2014;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "NASS";
        job2._jobTitle = "Technician";
        job2._startYear = 2011;
        job2._endYear = 2014;

        Resume resume = new Resume();
        resume._name = "Mathew Frenette";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();

    }
}
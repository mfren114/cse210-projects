using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "f";
        }
        
        Console.WriteLine($"Your lette grade is {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you failed. Please study and try again.");
        }
    }
}
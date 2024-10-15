using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Console.WriteLine("Hello Learning05 World!");
        Assignment assignment = new Assignment("Frenette", "Math");
        //string summary = assignment.GetSummary();
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("Frenette", "Math" ,"Section 7.3", "Problem 8-19");
        //string homeWorkList = mathAssignment.GetHomeWorkList();
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());


        WritingAssignment writingAssignment = new WritingAssignment("Frenette", "English", "Welcome to Egypt");
        //string getWritingInformation = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}
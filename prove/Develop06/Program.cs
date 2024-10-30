using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop06 World!");

        int userMenuInput = 0;
        int userGoalInput = 0;

        Console.Clear();
        Console.WriteLine("Welcome to the goal setting app!");
        Console.WriteLine();

        Console.WriteLine("Menu Option:");
        Console.WriteLine("1. Create new Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Please select a number: ");
        string userResponse = Console.ReadLine();
            userMenuInput = int.Parse(userResponse);

        if (userMenuInput == 1)
        {
            Console.WriteLine("The types od Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which goal number would you like to choose: ");
            string userGoalResponse = Console.ReadLine();
            userGoalInput = int.Parse(userGoalResponse);
            Goal goal = null;

            if (userGoalInput == 1)
            {
                goal = new SimpleGoal("", "", 0);
                goal.GetName();
                goal.DisplayPointValue();
            }
            else if (userGoalInput == 2)
            {
                goal = new EternalGoal("", "", 0, 0);
                goal.DisplayPointValue();
            }
            else if (userGoalInput == 3)
            {
                goal = new CheckListGoal("", "", 0);;
                goal.DisplayPointValue();
            }
        }
        else if (userMenuInput == 2)
        {

        }
        else if (userMenuInput == 3)
        {

        }
        else if (userMenuInput == 4)
        {

        }
        else if (userMenuInput == 5)
        {

        }
        else if (userMenuInput == 6)
        {
            Console.WriteLine("Have a good day- and come back soon!");
        }


    }
}
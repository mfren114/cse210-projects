using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int userNumber = 0;
        while (userNumber != 5)
         {   
            Console.WriteLine("Welcome to your journal. What would you like to do? "); 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose a number ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber == 1)
            {
                journal.AddEntry();
                break;  
            }
            else if (userNumber == 2)
            {
                journal.Displayall();
                break;
            }
            else if (userNumber == 3)
            {
                
            }
            else if (userNumber == 4)
            {

            }
            else 
            {
                Console.WriteLine("Have a good day, see you soon!");
            }
         }
        
    }
}
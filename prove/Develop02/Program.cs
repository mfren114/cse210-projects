//For exceeding requirements I added the current time of the entry made. This is returned when you load or display.

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
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose a number ");
            Console.Write("");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            //Write
            if (userNumber == 1)
            {
                journal.AddEntry();
                
            }
            //Display
            else if (userNumber == 2)
            {
                journal.Displayall();
                //break;
            }
            //Save
            else if (userNumber == 3)
            {
                Console.WriteLine("Saved to Journal.txt");
                //string saveFile = Console.ReadLine();
                journal.SaveToFile(journal._entries);
                Console.WriteLine("Your file has been saved!");
                //break;
            }
            //Load
            else if (userNumber == 4)
            {
                Console.Write("Which file would you like to load? ");
                string loadFile = Console.ReadLine();
                journal.LoadFile();
                //break;
            }
            //Quit
            else 
            {
                Console.WriteLine("Have a good day, see you soon!");
            }
         }
        
    }
}
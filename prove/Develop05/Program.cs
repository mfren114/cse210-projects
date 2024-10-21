using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        int userNumber = 0;
        while(userNumber != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a number from the menu: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if(userNumber == 1)
            {
                Console.Clear();
                Breathing breathing = new Breathing("Breathing Activity", "This activity will help you with your breathing", 0);
                breathing.Run();
                break;
            }
            else if(userNumber == 2)
            {
                Console.Clear();
                Reflection reflection = new Reflection("Reflection Activity", "This activity will help you think and reflect on past times", 0);
                reflection.Run();
                break;
            }
            else if(userNumber == 3)
            {
                Console.Clear();
                Listing listing = new Listing("Listing Activity", "This activity will help you remember good times by having you list as many things as you can in a certain area", 0, 0);
                listing.Run();
                break;
            }
            else
            {
                Console.WriteLine("See you later, have a good day.");
            }
        }
    }
}
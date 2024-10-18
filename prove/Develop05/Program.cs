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
                Breathing breathing = new Breathing("Breathing Activity", "This activity will help you with your breathing", 10);
                breathing.Run();
                break;
            }
            else if(userNumber == 2)
            {

            }
            else if(userNumber == 3)
            {

            }
            else
            {
                Console.WriteLine("See you later, have a good day.");
            }
        }
    }
}
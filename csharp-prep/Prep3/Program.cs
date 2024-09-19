using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int userNumber = -1;

        while (userNumber != magicNumber)
        {

            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());
        

            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else  
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
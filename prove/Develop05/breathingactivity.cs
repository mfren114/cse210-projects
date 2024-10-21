public class Breathing : Activity
{
    
    public Breathing(string name, string description, int userDuration) : base(name, description, userDuration)
    {
        
    }

    public void InOut()
    {
        int time = SessionLength() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;
        
        for (int i = 0; i < intervals; i++)
        {
            Console.WriteLine(i);
            
        }
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        InOut();
        DisplayEndingMessage();
    }
}
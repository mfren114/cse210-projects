using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();

        List<Activity> activityList = new List<Activity>();

        Cycling cycling = new Cycling(10, 5);
        activityList.Add(cycling);

        Running running = new Running(10, 5);
        activityList.Add(running);

        Swimming swimming = new Swimming(10, 5);
        activityList.Add(swimming);

        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
        }
    }
}
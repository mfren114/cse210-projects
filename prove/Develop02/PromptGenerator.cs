

public class PromptGenerator 
{

    public void GetRandomPrompt()
    {   
        //List of prompts
        List<string> prompts = new List<string>()
        {
            "What did you do today that really stood out to you?", 
            "Who did you meet today?",
            "What spiritual insights did you have?",
            "What interesting places did you go to today?",
            "What memories did you create with your family today?",
        };

        //Generate a random prompt from prompt list
        Random promptGenerator = new Random();
        int promptIndex = promptGenerator.Next(prompts.Count);
        Entry entry = new Entry();
        entry._promptText = prompts[promptIndex];
        Console.WriteLine(entry._promptText);
    }
     
}

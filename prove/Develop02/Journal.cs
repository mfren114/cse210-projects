        using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<PromptGenerator> _prompts = new List<PromptGenerator>();
    

    public void AddEntry()
    {
        Entry userEntry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        userEntry.GetTime();
        userEntry.GetDate();
        prompt.GetRandomPrompt();
        userEntry.Response();
        _entries.Add(userEntry);
        _prompts.Add(prompt);
    }

    public void Displayall()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Time: {entry._time}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
        }
    }

    public void SaveToFile(List<Entry> _entries) 
    {
        string filename = "journal.txt";
        
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._time}, {entry._date}, {entry._promptText}, {entry._entryText}");
                
            }
        }
    }

    public void LoadFile()
    {
        using (StreamReader read = new StreamReader("journal.txt"))
        {
            string journalEntries = read.ReadToEnd();
            Console.Write(journalEntries);
            //Return list of entries get file from user use split function 
        }
    }


}

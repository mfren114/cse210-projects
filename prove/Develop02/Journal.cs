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
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
        }
    }

    public void SaveToFile(string file)
    {
        StreamReader sr = new StreamReader("journal.txt");
        sr.ReadLine();
    }

    public void LoadFile()
    {

    }


}

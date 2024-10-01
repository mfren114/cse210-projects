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
        string filename = "jounal.txt";
        
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"Date:{entry._date}");
                outputfile.WriteLine($"Prompt:{entry._promptText}");
                outputfile.WriteLine($"{entry._entryText}");
            }
        }
    }

    public void LoadFile(string file)
    {
        using (StreamReader read = new StreamReader("journal.txt"))
        {
            string journalEntries = read.ReadToEnd();
            Console.Write(journalEntries);
        }
    }


}

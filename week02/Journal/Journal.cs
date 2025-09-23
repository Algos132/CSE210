using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();

        PromptGenerator prompt = new PromptGenerator();
        string promptText = prompt.GetRandomPrompt();
        newEntry._promptText = promptText;
        Console.WriteLine($"Prompt: \"{promptText}\"");
        Console.Write("Your entry: ");
        newEntry._entryText = Console.ReadLine();

        newEntry.Display();
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine("Saving to file...");
            
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"\nDate: {entry._date}\nPrompt: {entry._promptText}\nEntry: {entry._entryText}\n|");
            }
            // outputFile.Flush();
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry loadEntry = new Entry();

            _entries.Add(loadEntry);
            Console.WriteLine(line);
        }
    }
}
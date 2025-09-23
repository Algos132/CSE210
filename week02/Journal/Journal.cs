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
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}{System.Environment.NewLine}");
            }
            outputFile.Flush();
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry loadEntry = new Entry();
            loadEntry._date = parts[0];
            loadEntry._promptText = parts[1];
            loadEntry._entryText = parts[2];

            _entries.Add(loadEntry);
        }
    }
}
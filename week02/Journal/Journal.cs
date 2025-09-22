using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;


public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry}");
        }
    }

    public void SaveToFile(string file)
    {
        string filename = "journalEntries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Display()}");
            }
        }
    }
    
    public void LoadFromFile(string file, string date)
    {          

    }
}
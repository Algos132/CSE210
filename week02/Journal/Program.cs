using System;
using System.ComponentModel.Design;
using System.IO;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string menuResponse;
        Console.WriteLine("Welcome to your Journal.");
        Console.WriteLine("What would you like to do?");

        Console.WriteLine("1. Create an entry with a prompt: (enter \"Write\")");
        Console.WriteLine("2. See previous entries: (enter \"Entries\")");
        menuResponse = Console.ReadLine();

        if (menuResponse == "Write")
        {
            PromptGenerator prompt = new PromptGenerator();
            string promptText = prompt.GetRandomPrompt();

            Console.Write("Enter Date: ");
            string enteredDate = Console.ReadLine();
            Console.WriteLine($"Today's Prompt: \"{promptText}\"");
            string journalEntry = Console.ReadLine();

            Console.WriteLine("What would you like to do with your new entry?");
            Console.WriteLine("Save to file: (enter \"Save\")");
            Console.WriteLine("Quit: (enter \"Quit\")");
            string entryMenu = Console.ReadLine();

            if (entryMenu == "Save")
            {
                Entry entry = new Entry();
                entry._date = enteredDate;
                entry._promptText = promptText;
                entry._entryText = journalEntry;

                Journal newEntry = new Journal();
                newEntry.AddEntry(entry);
            }
            else if (entryMenu == "Quit")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
        }
        else if (menuResponse == "Entries")
        {
            Journal journal = new Journal();
            Console.WriteLine("Enter a date or type \"all\" to see all entries");
            string date = Console.ReadLine();

            if (date == "all")
            {
                journal.DisplayAll();
            }
            else
            {
                journal.LoadFromFile("journalEntries.txt", date);
            }
        }
    }
}
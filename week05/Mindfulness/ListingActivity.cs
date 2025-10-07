using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    : base("listing activity", "Think broadly, list a certain amount of things as you can in a certain area of strength or positivity. you may discover more breadth than you previously realized.")
    {
        _prompts.Add("How have you felt the Holy Ghost this month?");
        _prompts.Add("When was the last time you saw the Lord's hand in your life?");
        _prompts.Add("Name a time that you felt successful.");
        _prompts.Add("Is there someone feel like you can help? Who?");
        _prompts.Add("How have you served someone this last month?");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int prompt = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[prompt]);

    }
    public void Run()
    {
        // Introduction to this activity.
        List<string> newList = new List<string>();
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine("");

        // sets up time user needs to type, letting them finish their last entry.
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            string userInput = Console.ReadLine();
            newList.Add(userInput);
            currentTime = DateTime.Now;
            _count += 1;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        DisplayEndingMessage();
    }
}
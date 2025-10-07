using System;
using System.Collections.Generic;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name + ".\n");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, do you want to spend on this activity?");
        _duration = int.Parse(Console.ReadLine());

    }
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}!");
        Console.Write("Returning to menu... ");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

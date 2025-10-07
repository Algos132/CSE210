using System;
using System.Numerics;

class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("breathing activity", "A session of deep breathing for an entered amount of time. You will breathe in for five seconds, hold for one, and then exhale for four seconds.")
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.Clear();

        int totalDuration = _duration;

        for (int i = totalDuration; i >= 0;)
        {
            Console.Write("Breath in... ");
            ShowCountDown(5);
            Console.WriteLine("");
            i = i - 5;
            Console.Write("Hold... ");
            ShowSpinner(1);
            Console.WriteLine("");
            i = i - 1;
            Console.Write("Breath out... ");
            ShowCountDown(4);
            Console.WriteLine("\n");
            i = i - 4;
        }
        DisplayEndingMessage();
    }
}
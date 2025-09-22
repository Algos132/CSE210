using System.Security.Cryptography;
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("Who was the most interesting person I interacted with today?");
        promptList.Add("What was the best part of my day?");
        promptList.Add("How did I see the hand of the Lord in my life today?");
        promptList.Add("What was the strongest emotion I felt today?");
        promptList.Add("If I had one thing I could do over today, what would it be?");

        Random randomPrompt = new Random();
        int prompt = randomPrompt.Next(0, promptList.Count() - 1);
        return promptList[prompt];
    }
}
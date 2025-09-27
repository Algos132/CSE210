using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

class Scripture
{
    /*
    Ether 12:27 "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
    */

    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(string text)
    {
        string[] splitText = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (string newWord in splitText)
        {
            _words.Add(new Word(newWord));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // 1. Find all words that are not already hidden.
        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
        
        // 2. Determine how many words to hide (don't try to hide more than are available).
        int wordsToHideCount = Math.Min(numberToHide, unhiddenWords.Count);
        
        // 3. Hide the determined number of random words from the unhidden list.
        for (int i = 0; i < numberToHide; i++)
        {
            if (unhiddenWords.Count == 0) break;
            
            int indexToHide = _random.Next(unhiddenWords.Count);
            unhiddenWords[indexToHide].Hide();
            unhiddenWords.RemoveAt(indexToHide); // Remove from our temporary list to avoid hiding it again.
        }
    }

    public string GetDisplayText()
    {
        return $"{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        // checks if all words are hidden
        return _words.All(hidden => hidden.IsHidden());
    }
}
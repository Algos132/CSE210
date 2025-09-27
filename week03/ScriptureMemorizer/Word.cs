using System;
using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _ishidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _ishidden = true;
    }

    public void Show()
    {
        _ishidden = false;
    }

    public bool IsHidden()
    {
        return _ishidden;
    }

    public string GetDisplayText()
    {
        if (_ishidden == false)
        {
            return _text;
        }
        else
        {
            string replacement = new string('_', _text.Length);
            return replacement;
        }
    }    
}
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
        Console.WriteLine($"_words: {string.Join(", ", _words)}");
    }

    public void HideRandomWords(int numberToHide = 3)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        string verseText = "";
        foreach (Word word in _words)
        {
            verseText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {verseText.Trim()}";
    }
}
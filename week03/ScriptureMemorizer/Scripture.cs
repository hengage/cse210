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
    }

    public void HideRandomWords(int numberToHide = 3)
    {
         Random rand = new Random();

    // Get list of visible words
    List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());

    // If fewer visible words than count, adjust
    int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

    for (int i = 0; i < wordsToHide; i++)
    {
        int index = rand.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index); // Prevent hiding same word twice
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

    public static List<Scripture> LoadFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (string line in File.ReadAllLines(filePath))
        {
            string[] parts = line.Split('|');

            Reference reference;
            string text;

            if (parts.Length == 4)
            {
                // Format: Book|Chapter|Verse|Text
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                text = parts[3];

                reference = new Reference(book, chapter, verse);
            }
            else if (parts.Length == 5)
            {
                // Format: Book|Chapter|StartVerse|EndVerse|Text
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                text = parts[4];

                reference = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                // Skip malformed lines
                continue;
            }

        scriptures.Add(new Scripture(reference, text));
    }

    return scriptures;
    }
}
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }
    public void Display()
    {
        string content = "";

        foreach (Word word in _words)
        {
            content += word.GetDisplayText() + " ";
        }

        Console.WriteLine($"{_reference.GetDisplayText()} {content}");
    }
    public void HideRandomWords(int count)
    {
        int hidden = 0;
        while (hidden < count && !AllWordsHidden())
        {
            int index = _random.Next(_words.Count);
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
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

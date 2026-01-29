using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _title;
    public string _entry;

    public Entry(string date, string prompt, string title, string text)
    {
        _date = date;
        _prompt = prompt;
        _title = title;
        _entry = text;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine(_entry);
        Console.WriteLine("----------------------------------");
    }
}
    
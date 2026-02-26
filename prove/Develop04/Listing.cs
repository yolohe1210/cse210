using System;
using System.Collections.Generic;
using System.Threading;
public class Listing : Activity {
    private static List<string> _masterPrompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private static List<string> _unusedPrompts = new List<string>();
    private static Random _rng = new Random();
    public Listing() {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void RunListing(int seconds) 
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GeneratePrompt()} --- ");
        Console.WriteLine($"You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine(); 
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int listCount = 0;
        while (DateTime.Now < endTime) {
            Console.Write(" >");
            Console.ReadLine();
            listCount ++;
        }
        Console.WriteLine($"You listed {listCount} items.");
    }
    private static string GeneratePrompt() {
        if (_unusedPrompts.Count == 0) {
            _unusedPrompts = new List<string>(_masterPrompts);
        }
        int index = _rng.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);
        return prompt;
    }
}
using System;
using System.Collections.Generic;
using System.Threading;
public class Reflecting : Activity {
    public Reflecting() {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void RunReflecting(int seconds) {
        Console.WriteLine("\nConsidering the following prompt:");
        Console.WriteLine($"\n --- {GeneratePrompt()} --- ");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine($"You may begin in: ");
        ShowCountdown(5);

        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime && _unusedQuestions.Count > 0)
        {
            Console.Write($"> {GenerateQuestion()} ");
            ShowSpinner(5); 
            Console.WriteLine();
        }
    }
    private static List<string> _masterPrompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private static List<string> _masterQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private static List<string> _unusedPrompts = new List<string>();
    private static List<string> _unusedQuestions = new List<string>();
    private static Random _rng = new Random();
    private static string GeneratePrompt() {
        if (_unusedPrompts.Count == 0) {
            _unusedPrompts = new List<string>(_masterPrompts);
        }
        int randomIndex = _rng.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[randomIndex];
        _unusedPrompts.RemoveAt(randomIndex);
        return prompt;
    }
    private static string GenerateQuestion() 
    {
        if (_unusedQuestions.Count == 0) {
            _unusedQuestions = new List<string>(_masterQuestions);
        }
        int randomIndex = _rng.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[randomIndex];
        _unusedQuestions.RemoveAt(randomIndex);
        return question;
    }
}
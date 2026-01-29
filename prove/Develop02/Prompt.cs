using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What challenge did you face today?",
        "What are you grateful for today?",
        "What are some improvements you can do?",
        "What are some new things you learned?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}

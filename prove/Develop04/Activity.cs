using System;
using System.Collections.Generic; 
using System.Threading;
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }
    public void ShowCountdown(int seconds) 
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationCharacters = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationCharacters[i]);
            Thread.Sleep(250);
            Console.Write("\b \b"); 
            i = (i + 1) % animationCharacters.Count; 
        }
    }
    public virtual void Run() { }
}
using System;
public class Breathing : Activity 
{
    public Breathing() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunBreathing(int seconds) 
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(4); 
            Console.Write("\nBreathe out...");
            ShowCountdown(6); 
        }
    }
}
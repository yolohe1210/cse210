using System;

class Program
{
    static void Main()
    {
        DisplayMessage();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        int birthYear;
        PromtUserBirthYear(out birthYear);
        DisplayResult(name, square, birthYear);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write($"Please enter the year you were born: ");
        string year_str = Console.ReadLine();
        year = int.Parse(year_str);
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

     static void DisplayResult(string name, int square, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {2026-year} this year.");
    }
}
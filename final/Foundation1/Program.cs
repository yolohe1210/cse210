using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Do you really need to take 10,000 steps a day?", "TED-Ed", 384);
        video1.AddComment(new Comment("Anna", "Great video!"));
        video1.AddComment(new Comment("Lily", "Very inspiring."));
        video1.AddComment(new Comment("Tom", "I learned a lot."));
        videos.Add(video1);

        Video video2 = new Video("Hobbies: Your Best Defense Against Brain Rot", "Dr. Izzy Sealey", 1097);
        video2.AddComment(new Comment("Mike", "Helpful content."));
        video2.AddComment(new Comment("Sara", "Loved this."));
        video2.AddComment(new Comment("John", "Very clear explanation."));
        videos.Add(video2);

        Video video3 = new Video("How to Articulate Your Thoughts More Clearly Than 99% of People", "Leila Hormozi", 967);
        video3.AddComment(new Comment("Emma", "Nice tips!"));
        video3.AddComment(new Comment("Chris", "I will try this."));
        video3.AddComment(new Comment("David", "Good advice."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
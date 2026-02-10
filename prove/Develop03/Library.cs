using System;
using System.Collections.Generic;

public class Library
{
    private List<Scripture> _scriptures;
    private Random _random = new Random();

    public Library()
    {
        _scriptures = new List<Scripture>();
        _scriptures.Add(new Scripture(
            new Reference("Mosiah", 5, 3),
            "And we, ourselves, also, through the infinite goodness of God, and the manifestations of his Spirit, have great views of that which is to come; and were it expedient, we could prophesy of all things."
        ));
        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Jeremiah", 17, 7),
            "Blessed is the man that trusteth in the Lord, and whose hope the Lord is."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Psalm", 34, 4),
            "I sought the Lord, and he heard me, and delivered me from all my fears."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Romans", 15, 13),
            "Now the God of hope fill you with all joy and peace in believing, that ye may abound in hope, through the power of the Holy Ghost."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Matthew", 11, 28,30),
            "Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."
        ));
        _scriptures.Add(new Scripture(
            new Reference("Moroni", 7, 42, 43),
            "Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope. And again, behold I say unto you that he cannot have faith and hope, save he shall be meek, and lowly of heart."
        ));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}

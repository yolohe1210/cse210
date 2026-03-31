using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "Idaho", "USA");
        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address addr3 = new Address("789 Park Ave", "New York", "NY", "USA");

        Event lecture = new Lecture("Math Lecture", "Calculus 101", "4/10", "10:00", addr1, "Dr. Smith", 30);
        Event reception = new Reception("Networking Event", "Meet professionals", "4/12", "18:00", addr2, "rsvp@event.com");
        Event outdoor = new Outdoor("Spring Festival", "Enjoy the outdoors", "4/15", "12:00", addr3, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (var e in events)
        {
            Console.WriteLine(e.GetStandard());
            Console.WriteLine();
            Console.WriteLine(e.GetFull());
            Console.WriteLine();
            Console.WriteLine(e.GetShort());
            Console.WriteLine("---------------------------\n");
        }
    }
}
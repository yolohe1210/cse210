public class Reception : Event
{
    private string _rsvpInfo;

    public Reception(string title, string description, string date, string time, Address address, string rsvpInfo)
        : base(title, description, date, time, address)
    {
        _rsvpInfo = rsvpInfo;
    }

    protected override string GetExtraDetails() {
        return $"RSVP Info: {_rsvpInfo}";
    }

    protected override string GetEventType() {
        return "Reception";
    }
}
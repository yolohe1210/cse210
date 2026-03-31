public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandard() {
        return $"Standard details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public string GetShort() {
        return $"Short details:\nType: {GetEventType()}\nTitle: {_title}\nDate: {_date}";
    }

    public string GetFull() {
        return $"Full details:\nType: {GetEventType()}\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}\n{GetExtraDetails()}";
    }

    protected virtual string GetExtraDetails() {
        return "";
    }

    protected virtual string GetEventType() {
        return "General Event";
    }
}
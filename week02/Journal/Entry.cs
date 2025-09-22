public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        return $"~~{_date}\n\"{_promptText}\"\n{_entryText}";
    }
}
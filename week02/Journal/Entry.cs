class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()} - Prompt: {_promptText} - Entry: {_entryText}");
        Console.WriteLine();
    }
}
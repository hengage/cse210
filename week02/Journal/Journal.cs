class Journal
{
    private List<Entry> _entries;


    // // Add constructor to initialize the list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("\nEnter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // writer.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                // writer.WriteLine(entry._entryText);
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile()
{
    bool fileLoaded = false;
    
    while (!fileLoaded)
    {
        Console.Write("\nEnter filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                char delimiter = Path.GetExtension(filename).ToLower() == ".csv" ? ',' : '|';

                while ((line = reader.ReadLine()) != null)
                    {
                        // Handle quoted CSV values if present
                        string[] parts;
                        if (delimiter == ',' && line.Contains("\""))
                        {
                            parts = line.Split(delimiter)
                                      .Select(p => p.Trim('"', ' '))
                                      .ToArray();
                        }
                        else
                        {
                            parts = line.Split(delimiter);
                        }
                        if (parts.Length == 3)
                        {
                            var entry = new Entry
                            {
                                _date = DateTime.Parse(parts[0]),
                                _promptText = parts[1],
                                _entryText = parts[2]
                            };
                            _entries.Add(entry);
                        }
                    }
            }
            fileLoaded = true;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
            Console.Write("Would you like to try again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
                break;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
            break;
        }
    }
}
}

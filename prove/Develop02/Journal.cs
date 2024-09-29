using System.IO;

public class Journal
{
    public List<Entry> _entries = [];

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(
                $"Date: {entry._date} - Prompt: {entry._promptText} - {entry._entryText}"
            );
        }
    }

    public void SaveToFile(string file)
    {
        using StreamWriter outputfile = new(file);
        foreach (Entry entry in _entries)
        {
            outputfile.WriteLine(
                $"Date: {entry._date} - Prompt: {entry._promptText} - {entry._entryText}"
            );
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            string date = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];
            Entry entry = new()
            {
                _date = date,
                _promptText = prompt,
                _entryText = entryText
            };

            _entries.Add(entry);
        }
    }
}

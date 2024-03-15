// Sample code for creating the Journal class
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        Entry entry1 = new Entry();
        entry1._date = newEntry._date;
        entry1._promptText = newEntry._promptText;
        entry1._entryText = newEntry._entryText;

        _entries.Add(entry1);
    }

    public void DisplayAll()
    {
        foreach (Entry inf in _entries)
        {
            inf.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry save in _entries)
            {
                outputFile.WriteLine($"{save._date}/{save._promptText}/{save._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        List<Entry> entriesList = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(".");
            Entry saveSplit = new Entry();
            saveSplit._date = parts[0];
            saveSplit._promptText = parts[1];
            saveSplit._entryText = parts[2];
            entriesList.Add(saveSplit);
        }
        _entries = entriesList;
    }
}

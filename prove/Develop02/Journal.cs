public class Journal
{
    public List<string> _entries = new List<string>();

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        return _entries;
    }

}
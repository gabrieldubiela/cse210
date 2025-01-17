public class Entries
{
    List<string> _entries = new List<string>();
    List<string> _dates = new List<string>();
    public List<string> _all = new List<string>();
    
    public void SaveEntrie(string _entrie, string _date)
    {
        _entries.Add(_entrie);
        _dates.Add(_date);
        int _i = _entries.Count - 1;
        _all.Add(_dates[_i] + "\n" + _entries[_i] + "\n");

        Console.WriteLine ("Entry saved");
    }
}
public class Entries
{
    public List<string> _all = new List<string>();
    
    public void SaveEntrie(string _entrie, string _date, string _prompt)
    {
        _all.Add(_date + "\n" + _prompt + "\n" + _entrie + "\n");

        Console.WriteLine ("Entry saved");
    }
}
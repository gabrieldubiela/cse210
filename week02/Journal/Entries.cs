public class Entries
{
    public List<string> _all = new List<string>();
    
    public void SaveEntrie(string _entrie, string _date, string _prompt, string _mood)
    {
        _all.Add("Date: " + _date + " - Prompt: " + _prompt + "\n" + _entrie + "\n" + "Mood of the day: " + _mood);
    }
}

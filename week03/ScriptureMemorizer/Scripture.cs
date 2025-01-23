public class Scripture (Reference Reference, string text)

    Reference _reference = new Reference();
    private readonly List<string> _words = new() {}

    void HideRandomWords(int numberToHide)
        for (i = 3, i > 0, i--)
            var _random = new Random();
            int _index = _random.Next(_words.Count);
            
            _words.RemoveAt(_index);

    string GetDisplayText()

    bool IsCompleteHidden()
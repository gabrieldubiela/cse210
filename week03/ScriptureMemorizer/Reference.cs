public class Reference (string book, int chapter, int verse);

private string _book;
private int _chapter;
private int _verse;
private int _endVerse; 

public class Reference (string book, int chapter, int startVerse, int endVerse);

public string GetDisplayText()
    if (_endVerse = 0)
    {
        return string _reference = _book + " " + _chapter + ":" + _verse
    }

    else ()
    {
        return string _reference = _book + " " + _chapter + ":" + _verse + "-" + _endVerse
    }
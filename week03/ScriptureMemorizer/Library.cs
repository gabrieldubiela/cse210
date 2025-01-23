public class Library ()
{    
    private readonly List<string> _bookList = new()
    {
        "1 Nephi",
        "2 Nephi",
        "2 Nephi",
        "2 Nephi",
        "2 Nephi"
    };

    private readonly List<string> _chapterList = new() 
    {
        3,
        2,
        2,
        9,
        28
    };
    
    private readonly List<string> _verseList = new()
    {
        7, 
        25, 
        27, 
        28, 
        7
    };
    
    private readonly List<string> _endVerseList = new()
    {
        0,
        0, 
        0, 
        29, 
        9
    };

    private readonly List<string> _text = new() 
    {
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Adam fell that men might be; and men are, that they might have joy."
        "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.",
        "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.",
        "Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark."
    };

    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;
    public string _text;

    RandomScripture()
        var _random = new Random();
        int _index = _random.Next(_bookList.Count);
        _book = _bookList[_index];
        _chapter = _chapterList[_index];
        _verse = _verseList[_index];
        _endVerse = _endVerseList[_index];
        _text = _textList[_index];
}
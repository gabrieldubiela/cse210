public class Library
{    
    private readonly List<(string book, int chapter, int verse, int endVerse, string text)> _scripturesList = new List<(string, int, int, int, string)>()
    {
        ("1 Nephi", 3, 7, 0, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        ("2 Nephi", 2, 25, 0, "Adam fell that men might be; and men are, that they might have joy."),
        ("2 Nephi", 2, 27, 0, "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself."),
        ("2 Nephi", 9, 28, 29, "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God."),
        ("2 Nephi", 28, 7, 9, "Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark.")
    };
    public (string book, int chapter, int verse, int endVerse, string text) RandomScripture()
    {
        var _random = new Random();
        int _index = _random.Next(_scripturesList.Count);
        var _scripture = _scripturesList[_index];
        return _scripture;
    }
}
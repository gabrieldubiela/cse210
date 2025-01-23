using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        Library scripture = new Library();
        Word text = new Word(scripture._text)
        if scripture._endVerse = 0
            Reference reference = new Reference(scripture._book, scripture._chapter, scripture._verse)
        else
            Reference reference = new Reference(scripture._book, scripture._chapter, scripture._verse, scripture._endVerse)
        string _input;
        Scripture scripture = new Scripture();

        while (_input =! "quit")
        {
            Console.WriteLine(reference + \n + scripture)
            Console.Write('Press enter to continue or type "quit" to finish: ');
            _input = Console.ReadLine();
            scripture.HideRandomWords(3)
            Console.Clear()
        }
    }
}
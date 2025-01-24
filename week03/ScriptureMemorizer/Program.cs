// Have a library of scriptures. Each time will randomly give a scripture to the user.

using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Library library = new Library();
        var scriptureData = library.RandomScripture();
        Reference reference;
        if (scriptureData.endVerse == 0)
        {
            reference = new Reference(scriptureData.book, scriptureData.chapter, scriptureData.verse);
        }
        else
        {
            reference = new Reference(scriptureData.book, scriptureData.chapter, scriptureData.verse, scriptureData.endVerse);
        }
        Scripture scripture = new(reference, scriptureData.text);
        string _input = "";

        while (_input != "quit")
        {
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress enter to continue or type \"quit\" to finish: ");
            _input = Console.ReadLine();
            scripture.HideRandomWords(3);
            Console.Clear();
            if (scripture.IsCompleteHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}                
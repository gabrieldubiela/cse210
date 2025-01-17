using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Entries _entries = new Entries();
        RandomPrompt _prompt = new RandomPrompt();

        while (userChoice != 5) 
        {
            Console.WriteLine("Choose as option:");
            Console.WriteLine("1 - Add a new entry");
            Console.WriteLine("2 - List all entries");
            Console.WriteLine("3 - Save the journal to a file");
            Console.WriteLine("4 - Load the journal from a file");
            Console.WriteLine("5 - Exit");
            Console.Write("Enter the number of your choice: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string _generatePrompt = _prompt.GetRandomPrompt();
                Console.Write(_generatePrompt);
                string _newEntrie = Console.ReadLine();
                DateTime _theCurrentTime = DateTime.Now;
                string _date = _theCurrentTime.ToShortDateString();
                _entries.SaveEntrie(_newEntrie, _date, _generatePrompt);
                Console.WriteLine("");
            }
            else if (userChoice == 2)
            {
                foreach (string _entry in _entries._all)
                {
                    Console.WriteLine(_entry);
                }
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter the filename to save the journal: ");
                string _saveFilename = Console.ReadLine();

                using (StreamWriter _outputFile = new StreamWriter(_saveFilename))
                {
                    foreach (string _entry in _entries._all)
                    {
                        _outputFile.WriteLine(_entry);
                    }
                Console.WriteLine("Journal saved to " + _saveFilename);
                }
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter the filename to load the journal: ");
                string _openFilename = Console.ReadLine();
                string[] _lines = System.IO.File.ReadAllLines(_openFilename);
                foreach (string _line in _lines)
                    {
                        _entries._all.Add(_line); 
                    }
                Console.WriteLine("Journal loaded from " + _openFilename);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
            }
        }
    }
}
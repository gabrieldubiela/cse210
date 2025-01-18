// Save other information (mood of the day) in the journal entry.

using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Entries entries = new Entries();
        RandomPrompt prompt = new RandomPrompt();

        while (userChoice != 5) 
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) // write
            {
                string _generatePrompt = prompt.GetRandomPrompt();
                Console.Write(_generatePrompt);
                string _newEntrie = Console.ReadLine();
                DateTime currentTime = DateTime.Now;
                string _date = currentTime.ToShortDateString();
                Console.WriteLine("What is you mood of the day?");
                string _mood = Console.ReadLine();
                entries.SaveEntrie(_newEntrie, _date, _generatePrompt, _mood);
                Console.WriteLine("");
            }
            
            else if (userChoice == 2) // display
            {
                foreach (string _entry in entries._all)
                {
                    Console.WriteLine(_entry);
                }
            }
            
            else if (userChoice == 3) // load
            {
                Console.Write("Enter the filename to load the journal: ");
                string _openFilename = Console.ReadLine();
                string[] _lines = System.IO.File.ReadAllLines(_openFilename);
                entries._all.Clear();
                foreach (string _line in _lines)
                    {
                        entries._all.Add(_line); 
                    }
                Console.WriteLine("Journal loaded from " + _openFilename + "\n");
            }
            
            else if (userChoice == 4) // save
            {
                Console.Write("Enter the filename to save the journal: ");
                string _saveFilename = Console.ReadLine();

                using (StreamWriter _outputFile = new StreamWriter(_saveFilename))
                {
                    foreach (string _entry in entries._all)
                    {
                        _outputFile.WriteLine(_entry);
                    }
                Console.WriteLine("Journal saved to " + _saveFilename + "\n");
                }
            }

            else if (userChoice == 5) // quit
            {
                Console.WriteLine("Goodbye!");
            }
            
            else
            {
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
            }
        }
    }
}

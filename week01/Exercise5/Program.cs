using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber;
        Console.Write("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber * userNumber;
        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine(userName + ", the square of your number is " + squareNumber);
    }
}
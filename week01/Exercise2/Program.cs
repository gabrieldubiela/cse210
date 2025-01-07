using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;
        string aditionalGrade;

        int remainder = gradePercentage % 10;

        if (remainder >= 7)
        {
            aditionalGrade = "+";
        }
        else if (remainder <= 3)
        {
            aditionalGrade = "-";
        }
        else
        {
            aditionalGrade = "";
        }

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            aditionalGrade = "";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
            aditionalGrade = "";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}{aditionalGrade}.");

        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations, you passed!");
        }
        else
        {
            Console.Write("Unfortunately, you did not pass, but don't give up. You will get next time!");
        }
    }
}
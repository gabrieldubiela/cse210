using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        
        int number = -1;
        int sum = 0;
        int largest = -999999;
        int smallestPositive = 999999;
        
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
            if (numbers[i] > 0 && numbers[i] < smallestPositive)
            {
                smallestPositive = numbers[i];
            }
        }
        
        int average = sum / (numbers.Count);

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);
        Console.WriteLine("The smallest positive number is: " + smallestPositive);
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
        Console.WriteLine(num);
        }
    }
}
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        int number = 1;
        int averageLength = 0;
        int sum = 0;
        int biggestNumber = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            string ValueFromUser = Console.ReadLine();
            number = int.Parse(ValueFromUser);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        } while (number != 0);

        for (int i = 0; i < numbers.Count; i++)
        {
            averageLength++;
            sum = sum + numbers[i];
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / averageLength}");
        Console.WriteLine($"The biggest number is: {biggestNumber}");
    }
}
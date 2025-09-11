using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your percentage? ");
        string ValueFromUser = Console.ReadLine();

        int Percentage = int.Parse(ValueFromUser);

        if (Percentage >= 90)
        {
            Console.Write("Your grade is an A");
        }
        else if (Percentage >= 80)
        {
            Console.Write("Your grade is a B");
        }
        else if (Percentage >= 70)
        {
            Console.Write("Your grade is a C");
        }
        else if (Percentage >= 60)
        {
            Console.Write("Your grade is a D");
        }
        else
        {
            Console.Write("Your grade is a F");
        }

        if (Percentage >= 60)
        {
            Console.WriteLine(". Congradulations! You're passing!");
        }
        else
        {
            Console.WriteLine(". Sorry. You'll do better next time!");
        }
    }
}
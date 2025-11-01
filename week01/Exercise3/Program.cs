using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess;
        int times = 0;

        Console.WriteLine("Guess a number between 1 and 100: ");
        
        do
        {
            Console.Write("Enter your guess: ");

            string valueFromUser = Console.ReadLine();
            guess = int.Parse(valueFromUser);
            ++times;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        } while (number != guess);

        Console.WriteLine("Good guess!");
        Console.WriteLine($"You guessed {times} times.");

    }
}
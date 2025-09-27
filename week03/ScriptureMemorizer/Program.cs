using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        //Reference reference = new Reference("Ether", 12, 27);
        Reference reference = new Reference("Ether", 12, 27);
        Scripture scripture = new Scripture("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        bool running = true;
        while (running == true)
        {
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Write("\nPress enter to continue, or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.WriteLine("\nNo more words to hide! Ending program...");
    }   
}
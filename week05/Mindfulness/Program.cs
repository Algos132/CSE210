using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start listing activity.");
            Console.WriteLine("3. Start reflecting activity.");
            Console.WriteLine("4. Quit.");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                    // breathing activity
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();              
                    break;

                    // listing activity
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                    // reflecting activity
                case 3:
                    reflectingActivity reflectingActivity = new reflectingActivity();
                    reflectingActivity.Run();
                    break;

                    //quit
                case 4:
                    running = false;
                    break;

                    // invalid choice
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Done!");
        }

    }
}
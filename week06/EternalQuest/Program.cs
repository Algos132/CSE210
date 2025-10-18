using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");

        // loops the program until running = false.
        bool running = true;

        // Manages goals
        GoalManager goalManager = new GoalManager();

        // Holds the menu options and calls all needed functions based on user input.
        while (running)
        {
            Console.Clear();
            goalManager.DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What kind of goal would you like to create?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Checklist Goal");
                    Console.WriteLine("3. Eternal Goal");
                    int goalType = int.Parse(Console.ReadLine());
                    
                    Console.Write("Give a short name for your goal: ");
                    string newGoalName = Console.ReadLine();
                    Console.Write("Give a short description for your goal: ");
                    string newGoalDescription = Console.ReadLine();
                    Console.Write("How many points should this goal be worth? ");
                    string newGoalPoints = Console.ReadLine();

                    switch (goalType)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal(newGoalName, newGoalDescription, newGoalPoints, false);
                            goalManager.CreateGoal(simpleGoal);
                            break;
                        case 2:
                            Console.Write("How many times does this goal need to be completed for a bonus? ");
                            int newGoalTarget = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing this goal that many times? ");
                            int newGoalBonus = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(newGoalName, newGoalDescription, newGoalPoints, false, newGoalTarget, newGoalBonus, 0);
                            goalManager.CreateGoal(checklistGoal);
                            break;
                        case 3:
                            EternalGoal eternalGoal = new EternalGoal(newGoalName, newGoalDescription, newGoalPoints);
                            goalManager.CreateGoal(eternalGoal);
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The current goals are: ");
                    goalManager.ListGoalNames();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Save Goals...");
                    Console.Write("Choose a name for your file (do not include the file extension): ");
                    string filename = Console.ReadLine();
                    goalManager.SaveGoals(filename);
                    Console.WriteLine($"Saving {filename}.txt...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Saved");
                    Thread.Sleep(1000);
                    break;
                case 4:
                    Console.WriteLine("Enter the name of the file you would like to load (do not include the file extension): ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    Console.WriteLine($"Loading {loadFile}.txt...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Loaded");
                    Thread.Sleep(1000);
                    break;
                case 5:
                    Console.WriteLine("Which goal would you like to record an event for? ");
                    goalManager.ListGoalNames();
                    int chosenEvent = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(chosenEvent);
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
        
}
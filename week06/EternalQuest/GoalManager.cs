using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}: ");
            Console.WriteLine($"{_goals[i].GetDetailsString()}");
        }
        
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }
    public void RecordEvent(int chosenEvent)
    {
        _goals[chosenEvent - 1].RecordEvent();
        _score += _goals[chosenEvent - 1].GetPoints();
    }
    public void SaveGoals(string filename)
    {
        string saveFile = $"{filename}.txt";
        using (StreamWriter outputFile = new StreamWriter(saveFile))
        {
            // records the score for the save...
            outputFile.WriteLine($"{_score}");

            // ...then loops through all the goals in the _goals list
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine($"{_goals[i].GetStringRepresentation()}~|");
            }
        }
    }
    public void LoadGoals(string filename)
    {
        string loadFile = $"{filename}.txt";
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        _score = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("~|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];            

            if (type == "Simple")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(simpleGoal);
            }
            else if (type == "Checklist")
            {
                bool isComplete = bool.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                int amountCompleted = int.Parse(parts[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, isComplete, target, bonus, amountCompleted);
                _goals.Add(checklistGoal);
            }
            else if (type == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
        }
    }    
}
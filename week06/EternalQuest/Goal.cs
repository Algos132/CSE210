using System;
using System.Collections.Generic;

class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete = false;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    // When "Record event" is selected, this will be called to add a count to the goals completed and will change isComplete = true.
    // In the case of a checklist goal it will add a count to the number of times the goal has been completed. If the count of times the goal is completed is the same as the target, then it will then make _isComplete = True.
    // Here, this will be overridden by the specific goal's classes.
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public int GetPoints()
    {
        return int.Parse(_points);
    }
    public virtual string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_shortName} ({_description}) worth {_points} points.";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) worth {_points} points.";
        }

        
    }
    
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}~|{_description}~|{_points}~|";
    }

}
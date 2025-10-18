using System;
using System.Collections.Generic;

class SimpleGoal : Goal
{
    
    public SimpleGoal(string name, string description, string points, bool isComplete)
    : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple~|{_shortName}~|{_description}~|{_points}~|{_isComplete}~|";
    }
}
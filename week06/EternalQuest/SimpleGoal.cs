using System;
using System.Collections.Generic;

class SimpleGoal : Goal
{
    
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points, bool isComplete)
    : base(name, description, points)
    {
        int _points = int.Parse(points);
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
        return $"Simple~|{GetName()}~|{GetDescription()}~|{GetPointsString()}~|{_isComplete}~|";
    }
}
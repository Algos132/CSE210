using System;
using System.Collections.Generic;

class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, bool isComplete, int target, int bonus, int amountCompleted)
    : base(name, description, points)
    {

        _isComplete = isComplete;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
        return _isComplete;
    }
    public override string GetDetailsString()
    {

        if (IsComplete() == true)
        {
            return $"[x] {GetName()} ({GetDescription()}) worth {GetPoints()} points. Completed all {_target} times and earned {_bonus} bonus points!";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) worth {GetPoints()} points. Completed {_amountCompleted} out of {_target} times.";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist~|{GetName()}~|{GetDescription()}~|{GetPoints()}~|{_isComplete}~|{_amountCompleted}~|{_target}~|{_bonus}~|";
    }
}
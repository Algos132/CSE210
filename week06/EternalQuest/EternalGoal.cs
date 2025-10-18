using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
    : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never finished so IsComplete will always be false.
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal~|{GetName()}~|{GetDescription()}~|{GetPointsString()}~|";
    ;
    }
}
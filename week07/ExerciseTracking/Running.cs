using System;

class Running : Activity
{
    private float _distance; // in miles

    public Running(int minutes, float distance)
        : base(minutes)
    {
        _activity = "Running";
        _distance = distance;
    }
    
    public override void Calculations()
    {
        _speed = _distance / _minutes * 60;
        _pace = _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date} {_activity} ({_minutes} min) Distance {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
    }
}
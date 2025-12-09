using System;

class Cycling : Activity
{
    private float _speed; // in miles

    public Cycling(int minutes, float speed)
        : base(minutes)
    {
        _activity = "Cycling";
        _speed = speed;
    }

    public override void Calculations()
    {
        _distance = _speed * _minutes / 60;
        _pace = 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} {_activity} ({_minutes} min) Distance {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
    }
}
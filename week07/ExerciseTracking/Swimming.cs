using System;

class Swimming : Activity
{
    private float _laps;
    private float _distance; // in miles

    public Swimming(int minutes, float laps)
        : base(minutes)
    {
        _activity = "Swimming";
        _laps = laps;
    }

    public override void Calculations()
    {
        _distance = _laps * 50 / 1000 * 0.62f; // Convert laps to miles
        _speed = _distance / _minutes * 60;
        _pace = _distance / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} {_activity} ({_minutes} min) Distance {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
    }
}
using System;

class Activity
{
    // Datetime
    private DateTime _time = DateTime.Now;
    protected string _date
    {
        get { return _time.ToString("dd MMMM yyyy"); }
    }

    // Activity info
    protected string _activity;
    protected float _minutes;
    protected float _distance = 0;
    protected float _speed = 0;
    protected float _pace = 0;
    protected float _laps = 0;


    public Activity(int minutes)
    {
        _minutes = minutes;
    }

    public virtual void Calculations()
    {
        
    }
    public virtual string GetSummary()
    {
        // Example: "03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile"
        return $"{_date} {_activity} ({_minutes} min) Distance {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile";
    }
}
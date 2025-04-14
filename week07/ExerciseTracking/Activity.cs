using System;

public abstract class Activity
{
    // Common properties for all activities
    public DateTime Date { get; set; }
    public double Minutes { get; set; }

    public Activity(DateTime date, double minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method that uses other methods
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Minutes} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

public class Running : Activity
{
    public double Distance { get; set; } // in miles

    public Running(DateTime date, double minutes, double distance) : base(date, minutes)
    {
        Distance = distance;
    }

    // Override methods
    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60; // Speed in miles per hour
    public override double GetPace() => Minutes / Distance; // Pace in minutes per mile
}

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, double minutes, int laps) : base(date, minutes)
    {
        Laps = laps;
    }

    // Override methods
    public override double GetDistance() => Laps * 50 / 1000.0; // Distance in miles (50 meters per lap)
    public override double GetSpeed() => (GetDistance() / Minutes) * 60; // Speed in miles per hour
    public override double GetPace() => Minutes / GetDistance(); // Pace in minutes per mile
}

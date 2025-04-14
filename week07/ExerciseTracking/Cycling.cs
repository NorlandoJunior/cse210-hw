public class Cycling : Activity
{
    public double Speed { get; set; } // in miles per hour

    public Cycling(DateTime date, double minutes, double speed) : base(date, minutes)
    {
        Speed = speed;
    }

    // Override methods
    public override double GetDistance() => (Speed * Minutes) / 60; // Distance in miles
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed; // Pace in minutes per mile
}

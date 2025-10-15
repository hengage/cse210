using ExerciseTracking;

public class Running: Activity
{
    private double _distance; // in kilometers

    public Running(string date, int lengthInMinutes, double distance) : 
    base(date, lengthInMinutes, "Running")
    {
        _distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getSpeed()
    {
        return _distance / _lengthInMinutes * 60;
    }

    public override double getPace()
    {
        return _lengthInMinutes / _distance;
    }
}
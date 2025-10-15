using ExerciseTracking;


public class Swimming: Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int lengthInMinutes, int numberOfLaps) : 
        base(date, lengthInMinutes, "Swimming")
    {
        _numberOfLaps = numberOfLaps;
    }
    
    public override double getDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double getSpeed()
    {
        return getDistance() / _lengthInMinutes * 60;
    }

    public override double getPace()
    {
        return _lengthInMinutes / getDistance();
    }

}

using ExerciseTracking;


public class Cycling: Activity
{
    private int _speed;

    public Cycling(string date, int lengthInMinutes, int speed) : 
    base(date, lengthInMinutes, "Cycling")
    {
        _speed = speed;
    }
    
    public override double getDistance()
    {
        return _speed * _lengthInMinutes;
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        return 60 / _speed;
    }

}

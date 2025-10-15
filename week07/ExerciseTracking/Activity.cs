using System.Globalization;
namespace ExerciseTracking;
public abstract class Activity
{
    private DateTime _date;
    protected int _lengthInMinutes;

    protected string _activity;

    public Activity(string date, int lengthInMinutes, string activity)
    {
        _date = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        _lengthInMinutes = lengthInMinutes;
        _activity = activity;
    }

    public abstract double getDistance();

    public abstract double getSpeed();

    public abstract double getPace();

    public virtual string getSummary()
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return $"Date: {_date.ToString("dd MMM yyyy")} {textInfo.ToTitleCase(_activity)} ({_lengthInMinutes}m) - " +
               $"Distance {getDistance():F2} kilometers, Speed {getSpeed():F2} mph, Pace {getPace():F2} min per mile";
    }
};
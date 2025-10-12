using System;

public class TimedGoal : Goal
{
    private bool _isComplete;
    private DateTime _deadline;
    private int _bonusPoints;

    public TimedGoal(string name, string description, string points, int daysToComplete, int bonusPoints) 
        : base(name, description, points)
    {
        _isComplete = false;
        _deadline = DateTime.Now.AddDays(daysToComplete);
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public bool IsExpired()
    {
        return DateTime.Now > _deadline && !_isComplete;
    }

    public bool EarnedBonus()
    {
        return _isComplete && DateTime.Now <= _deadline;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override string GetDetailsString()
    {
        string completionMark = IsComplete() ? "[X]" : IsExpired() ? "[EXPIRED]" : "[ ]";
        string deadlineStr = _deadline.ToString("MM/dd/yyyy");
        return $"{completionMark} {_shortName} ({_description}) -- Deadline: {deadlineStr}";
    }

    public override string GetStringRepresentation()
    {
        return $"TimedGoal:|{_shortName}|{_description}|{_points}|{_deadline:yyyy-MM-dd}|{_bonusPoints}|{_isComplete}";
    }
}
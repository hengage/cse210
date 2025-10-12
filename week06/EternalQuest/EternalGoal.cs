public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Return points each time, but never complete
        int points = int.Parse(_points);
        // Points will be added by the GoalManager
    }

    public override bool IsComplete()
    {
        return false;  // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) -- Eternal Goal";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:|{_shortName}|{_description}|{_points}";
    }
}
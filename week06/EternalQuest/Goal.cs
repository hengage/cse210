public abstract class Goal
{
    protected string _shortName;
    protected string _description;
        protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods that must be implemented by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    
    // Virtual method with default implementation
    public virtual string GetDetailsString()
    {
        string completionMark = IsComplete() ? "[X]" : "[ ]";
        return $"{completionMark} {_shortName} ({_description})";
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetPoints()
    {
        return _points;
    }
}
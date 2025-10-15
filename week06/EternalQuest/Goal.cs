public abstract class Goal
{
    private string _name = "";
    private string _description = "";
    private int _points = 0;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public abstract bool IsComplete();
    public abstract int StepGoal();
    public abstract string GoalType();
    public abstract string GetGoal();
    public abstract string SaveGoal();
}
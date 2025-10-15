public class Simple : Goal
{
    bool _isComplete = false;
    public Simple(string name, string description, int points) : base(name, description, points)
    {

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override int StepGoal()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override string GoalType()
    {
        return "Simple";
    }
    public override string GetGoal()
    {
        return $"Goal Name: {GetName()}\nGoal Type: {GoalType()}\nGoal Description: {GetDescription()}\nPoint Value: {GetPoints()}\nIs Complete: {IsComplete()}\n";
    }
    public override string SaveGoal()
    {
        return $"{GoalType()}:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }
}
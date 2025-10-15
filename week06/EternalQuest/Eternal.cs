public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override int StepGoal()
    {
        return GetPoints();
    }
    public override string GoalType()
    {
        return "Eternal";
    }
    public override string GetGoal()
    {
        return $"Goal Name: {GetName()}\nGoal Type: {GoalType()}\nGoal Description: {GetDescription()}\nPoint Value: {GetPoints()}\n";
    }
    public override string SaveGoal()
    {
        return $"{GoalType()}:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
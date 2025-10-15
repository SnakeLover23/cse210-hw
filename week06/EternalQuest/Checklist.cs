public class Checklist : Goal
{
    private int _bonusPoints = 0;
    private int _timesRequired = 0;
    private int _timesDone = 0;
    public Checklist(string name, string description, int points, int bonusPoints, int timesRequired) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesRequired = timesRequired;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public int GetTimesRequired()
    {
        return _timesRequired;
    }
    public int GetTimesDone()
    {
        return _timesDone;
    }
    public void SetTimesDone(int timesDone)
    {
        _timesDone = timesDone;
    }
    public override bool IsComplete()
    {
        if (_timesDone >= _timesRequired)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int StepGoal()
    {
        _timesDone = _timesDone + 1;
        if (_timesDone == _timesRequired)
        {
            return GetPoints() + _bonusPoints;
        }
        else
        {
            return GetPoints();
        }
    }
    public override string GoalType()
    {
        return "Checklist";
    }
    public override string GetGoal()
    {
        return $"Goal Name: {GetName()}\nGoal Type: {GoalType()}\nGoal Description: {GetDescription()}\nPoint Value: {GetPoints()}\nBonus Point Value: {GetBonusPoints()}\nTimes Required: {GetTimesRequired()}\nTimes Done: {GetTimesDone()}\nIs Complete: {IsComplete()}\n";
    }
    public override string SaveGoal()
    {
        return $"{GoalType()}:{GetName()},{GetDescription()},{GetPoints()},{GetBonusPoints()},{GetTimesRequired()},{GetTimesDone()}";
    }
}
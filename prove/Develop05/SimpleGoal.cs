class SimpleGoal : Goal
{
    public override void MarkAsComplete()
    {
        IsCompleted = true;
        PointsEarned = CalculatePoints();
    }

    public override int CalculatePoints()
    {
        return 1000;
    }
}

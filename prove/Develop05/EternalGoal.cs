class EternalGoal : Goal
{
    public override void MarkAsComplete()
    {
        PointsEarned = CalculatePoints();
    }

    public override int CalculatePoints()
    {
        return 100;
    }
}

class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; set; }

    public ChecklistGoal(int targetCount)
    {
        TargetCount = targetCount;
    }

    public override void MarkAsComplete()
    {
        CompletionCount++;
        PointsEarned = CalculatePoints();

        if (CompletionCount == TargetCount)
        {
            PointsEarned += 500;
            IsCompleted = true;
        }
    }

    public override int CalculatePoints()
    {
        return 50;
    }
}

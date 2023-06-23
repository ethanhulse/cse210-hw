using System;

abstract class Goal
{
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public int PointsEarned { get; set; }

    public abstract void MarkAsComplete();
    public abstract int CalculatePoints();
}

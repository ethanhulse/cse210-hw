abstract class Task : ILoggable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public string Assignee { get; set; }

    public Task(string title, string description, int priority, DateTime dueDate, string assignee)
    {
        Title = title;
        Description = description;
        Priority = priority;
        DueDate = dueDate;
        IsCompleted = false;
        Assignee = assignee;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
        LogEvent($"Task '{Title}' marked as completed.");
    }

    public abstract void LogEvent(string log);
}
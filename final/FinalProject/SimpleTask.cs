class SimpleTask : Task
{
    public SimpleTask(string title, string description, int priority, DateTime dueDate, string assignee)
        : base(title, description, priority, dueDate, assignee)
    {
    }

    public override void LogEvent(string log)
    {
        Console.WriteLine($"[SimpleTask] {log}");
    }
}

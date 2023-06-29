class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string title, string description, int priority, DateTime dueDate)
    {
        Title = title;
        Description = description;
        Priority = priority;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }

    public override string ToString()
    {
        return $"{Title}\nPriority: {Priority}\nDue Date: {DueDate}\nCompleted: {(IsCompleted ? "Yes" : "No")}\n";
    }
}


class TaskManager
{
    private List<Task> tasks;
    private TaskValidator validator;
    private FileManager fileManager;
    private Logger logger;

    public TaskManager()
    {
        tasks = new List<Task>();
        validator = new TaskValidator();
        fileManager = new FileManager();
        logger = new Logger();
    }

    public void AddTask(Task task)
    {
        if (validator.ValidateTask(task))
        {
            tasks.Add(task);
            logger.LogEvent($"Task '{task.Title}' added.");
        }
        else
        {
            Console.WriteLine("Invalid task. Please check the task details.");
        }
    }

    public void RemoveTask(Task task)
    {
        tasks.Remove(task);
        logger.LogEvent($"Task '{task.Title}' removed.");
    }

    public List<Task> GetTasks()
    {
        return tasks;
    }

    public List<Task> FilterTasks(Predicate<Task> filter)
    {
        return tasks.FindAll(filter);
    }

    public void SortTasks(Comparison<Task> comparison)
    {
        tasks.Sort(comparison);
    }

    public void LoadTasks()
    {
        tasks = fileManager.LoadTasks();
        logger.LogEvent("Tasks loaded from file.");
    }

    public void SaveTasks()
    {
        fileManager.SaveTasks(tasks);
        logger.LogEvent("Tasks saved to file.");
    }

    public string GetLog()
    {
        return logger.GetLog();
    }
}

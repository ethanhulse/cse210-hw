class FileManager
{
    private const string FileName = "tasks.txt";

    public List<Task> LoadTasks()
    {
        List<Task> tasks = new List<Task>();

        try
        {
            string[] lines = File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 6)
                {
                    string taskType = parts[0];
                    string title = parts[1];
                    string description = parts[2];
                    int priority = int.Parse(parts[3]);
                    DateTime dueDate = DateTime.Parse(parts[4]);
                    bool isCompleted = bool.Parse(parts[5]);

                    Task task;
                    if (taskType == "SimpleTask")
                    {
                        task = new SimpleTask(title, description, priority, dueDate, "");
                    }
                    else if (taskType == "ComplexTask")
                    {
                        string assignee = description; // Use description as assignee for ComplexTask
                        task = new ComplexTask(title, "", priority, dueDate, assignee);
                    }
                    else
                    {
                        // Default to SimpleTask if task type is not recognized
                        task = new SimpleTask(title, description, priority, dueDate, "");
                    }

                    task.IsCompleted = isCompleted;
                    tasks.Add(task);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading tasks: {ex.Message}");
        }

        return tasks;
    }

    public void SaveTasks(List<Task> tasks)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                foreach (Task task in tasks)
                {
                    string taskType = task is ComplexTask ? "ComplexTask" : "SimpleTask";
                    string title = task.Title;
                    string description = task is ComplexTask ? task.Assignee : task.Description;
                    string priority = task.Priority.ToString();
                    string dueDate = task.DueDate.ToString("yyyy-MM-dd");
                    string isCompleted = task.IsCompleted.ToString();

                    writer.WriteLine($"{taskType}|{title}|{description}|{priority}|{dueDate}|{isCompleted}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving tasks: {ex.Message}");
        }
    }
}
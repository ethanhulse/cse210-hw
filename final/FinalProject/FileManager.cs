class FileManager
{
    private const string FileName = "tasks.txt";

    public List<Task> LoadTasks()
    {
        List<Task> tasks = new List<Task>();

        try
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    string title = parts[0];
                    string description = parts[1];
                    int priority = int.Parse(parts[2]);
                    DateTime dueDate = DateTime.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);

                    Task task = new Task(title, description, priority, dueDate);
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
            List<string> lines = new List<string>();
            foreach (Task task in tasks)
            {
                string line = $"{task.Title}|{task.Description}|{task.Priority}|{task.DueDate}|{task.IsCompleted}";
                lines.Add(line);
            }

            System.IO.File.WriteAllLines(FileName, lines);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving tasks: {ex.Message}");
        }
    }
}
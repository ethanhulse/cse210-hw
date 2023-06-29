class UserInterface
{
    private TaskManager taskManager;

    public UserInterface(TaskManager taskManager)
    {
        this.taskManager = taskManager;
    }

    public void ShowMenu()
    {
        Console.WriteLine("Task Management System");
        Console.WriteLine("1. Create Task");
        Console.WriteLine("2. Mark Task as Completed");
        Console.WriteLine("3. Show All Tasks");
        Console.WriteLine("4. Filter Tasks");
        Console.WriteLine("5. Sort Tasks");
        Console.WriteLine("6. Save Tasks");
        Console.WriteLine("7. Load Tasks");
        Console.WriteLine("8. Show Log");
        Console.WriteLine("9. Exit");
        Console.Write("Enter your choice: ");
    }

    public void Run()
    {
        int choice;
        do
        {
            ShowMenu();
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input. Enter your choice: ");
            }

            switch (choice)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    MarkTaskAsCompleted();
                    break;
                case 3:
                    ShowAllTasks();
                    break;
                case 4:
                    FilterTasks();
                    break;
                case 5:
                    SortTasks();
                    break;
                case 6:
                    SaveTasks();
                    break;
                case 7:
                    LoadTasks();
                    break;
                case 8:
                    ShowLog();
                    break;
                case 9:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 9);
    }

    private void CreateTask()
    {
        Console.WriteLine("Enter task details:");
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Priority (1-5): ");
        int priority;
        while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
        {
            Console.Write("Invalid priority. Enter a number between 1 and 5: ");
        }

        Console.Write("Due Date (yyyy-MM-dd): ");
        DateTime dueDate;
        while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
        {
            Console.Write("Invalid due date. Enter a valid date (yyyy/MM/dd) (Ex: 2001/04/02): ");
        }

        Task task = new Task(title, description, priority, dueDate);
        taskManager.AddTask(task);
        Console.WriteLine("Task created successfully!");
    }

    private void MarkTaskAsCompleted()
    {
        Console.WriteLine("Enter the index of the task to mark as completed:");
        List<Task> tasks = taskManager.GetTasks();
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"[{i}] {tasks[i].Title}");
        }

        int index;
        while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= tasks.Count)
        {
            Console.Write("Invalid index. Enter a valid index: ");
        }

        Task task = tasks[index];
        task.MarkAsCompleted();
        Console.WriteLine("Task marked as completed!");
    }

    private void ShowAllTasks()
    {
        List<Task> tasks = taskManager.GetTasks();
        Console.WriteLine("All Tasks:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    private void FilterTasks()
    {
        Console.WriteLine("Filter Tasks:");
        Console.Write("Enter the minimum priority (1-5): ");
        int minPriority;
        while (!int.TryParse(Console.ReadLine(), out minPriority) || minPriority < 1 || minPriority > 5)
        {
            Console.Write("Invalid priority. Enter a number between 1 and 5: ");
        }

        Console.Write("Enter the due date range (yyyy-MM-dd): ");
        DateTime minDueDate;
        while (!DateTime.TryParse(Console.ReadLine(), out minDueDate))
        {
            Console.Write("Invalid due date. Enter a valid date (yyyy-MM-dd): ");
        }

        Predicate<Task> filter = task => task.Priority >= minPriority && task.DueDate >= minDueDate;
        List<Task> filteredTasks = taskManager.FilterTasks(filter);
        Console.WriteLine("Filtered Tasks:");
        foreach (Task task in filteredTasks)
        {
            Console.WriteLine(task);
        }
    }

    private void SortTasks()
    {
        Console.WriteLine("Sort Tasks:");
        Console.WriteLine("1. Sort by Priority (Descending)");
        Console.WriteLine("2. Sort by Due Date (Ascending)");
        Console.Write("Enter your choice: ");

        int sortChoice;
        while (!int.TryParse(Console.ReadLine(), out sortChoice) || sortChoice < 1 || sortChoice > 2)
        {
            Console.Write("Invalid choice. Enter a valid choice: ");
        }

        switch (sortChoice)
        {
            case 1:
                taskManager.SortTasks((task1, task2) => task2.Priority.CompareTo(task1.Priority));
                break;
            case 2:
                taskManager.SortTasks((task1, task2) => task1.DueDate.CompareTo(task2.DueDate));
                break;
        }

        Console.WriteLine("Tasks sorted successfully!");
    }

    private void SaveTasks()
    {
        taskManager.SaveTasks();
        Console.WriteLine("Tasks saved successfully!");
    }

    private void LoadTasks()
    {
        taskManager.LoadTasks();
        Console.WriteLine("Tasks loaded successfully!");
    }

    private void ShowLog()
    {
        string log = taskManager.GetLog();
        Console.WriteLine("Log:");
        Console.WriteLine(log);
    }
}



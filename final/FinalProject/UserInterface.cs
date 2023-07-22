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
        Console.WriteLine("1. Create Simple Task");
        Console.WriteLine("2. Create Complex Task");
        Console.WriteLine("3. Mark Task as Completed");
        Console.WriteLine("4. Show All Tasks");
        Console.WriteLine("5. Exit");
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
                    CreateSimpleTask();
                    break;
                case 2:
                    CreateComplexTask();
                    break;
                case 3:
                    MarkTaskAsCompleted();
                    break;
                case 4:
                    ShowAllTasks();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 5);
    }

    private void CreateSimpleTask()
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
            Console.Write("Invalid due date. Enter a valid date (yyyy-MM-dd): ");
        }

        Console.Write("Assignee: ");
        string assignee = Console.ReadLine();

        Task task = new SimpleTask(title, description, priority, dueDate, assignee);
        taskManager.AddTask(task);
        Console.WriteLine("Simple Task created successfully!");
    }

    private void CreateComplexTask()
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
            Console.Write("Invalid due date. Enter a valid date (yyyy-MM-dd): ");
        }

        Console.Write("Assignee: ");
        string assignee = Console.ReadLine();

        Task task = new ComplexTask(title, description, priority, dueDate, assignee);
        taskManager.AddTask(task);
        Console.WriteLine("Complex Task created successfully!");
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
}
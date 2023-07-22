using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        FileManager fileManager = new FileManager();

        // Load tasks from file
        List<Task> tasks = fileManager.LoadTasks();
        foreach (Task task in tasks)
        {
            taskManager.AddTask(task);
        }

        UserInterface userInterface = new UserInterface(taskManager);

        userInterface.Run();

        // Save tasks to file after the user interaction
        tasks = taskManager.GetTasks();
        fileManager.SaveTasks(tasks);
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();
        UserInterface userInterface = new UserInterface(taskManager);
        userInterface.Run();
    }
}

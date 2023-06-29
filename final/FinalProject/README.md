# Task Management System Documentation
##### Written by Ethan Hulse - 2023
The Task Management System is a console-based application designed to help users manage their tasks effectively. It provides functionality to create tasks, mark tasks as completed, filter tasks based on priority and due date, sort tasks, save tasks to a file, and load tasks from a file.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [Class Structure](#class-structure)
- [File Management](#file-management)
- [Logging](#logging)
- [Contributing](#contributing)
- [License](#license)

## Features

The Task Management System offers the following features:

1. Create Task: Users can create new tasks by providing a title, description, priority, and due date.
2. Mark Task as Completed: Users can mark tasks as completed, indicating that the task has been finished.
3. Show All Tasks: Users can view all tasks currently stored in the system.
4. Filter Tasks: Users can filter tasks based on minimum priority and due date.
5. Sort Tasks: Users can sort tasks by priority (descending) or due date (ascending).
6. Save Tasks: Users can save all tasks to a file for future retrieval.
7. Load Tasks: Users can load previously saved tasks from a file.
8. Show Log: Users can view a log of system events, such as task additions and removals.

## Getting Started

To run the Task Management System, follow these steps:

1. Ensure you have the latest version of the .NET Framework installed.
2. Download the source code or clone the repository.
3. Open a command prompt or terminal and navigate to the project directory.
4. Compile the source code using the `dotnet build` command.
5. Run the application using the `dotnet run` command.


## Class Structure

The Task Management System is implemented using several classes:

- `Task`: Represents a single task with properties such as title, description, priority, due date, and completion status.
- `TaskManager`: Manages the collection of tasks, provides operations such as task addition, removal, filtering, and sorting.
- `UserInterface`: Handles the interaction with the user, displays the menu, and executes user-selected actions.
- `TaskValidator`: Validates task details before adding them to the task manager.
- `FileManager`: Handles the loading and saving of tasks to a file.
- `Logger`: Logs system events for future reference.

## File Management

Tasks are stored in a text file named "tasks.txt" in a pipe-separated format. Each line represents a single task with the following fields:

Title|Description|Priority|DueDate|IsCompleted


When saving tasks, the existing file is overwritten with the updated task list. When loading tasks, the file is read, and the tasks are reconstructed from the saved data.

## Logging

The Task Management System maintains a log of system events using the `Logger` class. Events such as task additions, completions, and other important actions are logged with a timestamp for reference.

The log can be viewed using the "Show Log" menu option in the application.

## Contributing

Contributions to the Task Management System are welcome! If you have any ideas, suggestions, or bug reports, please submit them via the issue tracker on the project's GitHub repository.

To contribute code, fork the repository, make your changes, and submit a pull request. Ensure that your code adheres to the project's coding style and passes all tests.

## License

The Task Management System is released under the [MIT License](https://opensource.org/licenses/MIT). You are free to use, modify, and distribute the code as per the terms of the license.

---


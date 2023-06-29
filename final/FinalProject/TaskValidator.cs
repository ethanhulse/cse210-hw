class TaskValidator
{
    public bool ValidateTask(Task task)
    {
        if (string.IsNullOrWhiteSpace(task.Title) || string.IsNullOrWhiteSpace(task.Description))
        {
            return false;
        }

        if (task.Priority < 1 || task.Priority > 5)
        {
            return false;
        }

        return true;
    }
}

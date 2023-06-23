using System.Collections.Generic;
using System.IO;

class GoalTracker
{
    private List<Goal> goals;
    private int totalScore;

    public GoalTracker()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void CreateGoal(string description, string type, int targetCount = 0)
    {
        Goal goal;

        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal();
                break;
            case "eternal":
                goal = new EternalGoal();
                break;
            case "checklist":
                goal = new ChecklistGoal(targetCount);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goal.Description = description;
        goals.Add(goal);
    }

    public void RecordGoalCompletion(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal goal = goals[goalIndex];

            if (!goal.IsCompleted)
            {
                goal.MarkAsComplete();
                totalScore += goal.PointsEarned;
            }
            else
            {
                Console.WriteLine("Goal already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string completionStatus = goal.IsCompleted ? "[X]" : "[ ]";

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{completionStatus} {goal.Description} (Completed {checklistGoal.CompletionCount}/{checklistGoal.TargetCount} times)");
            }
            else
            {
                Console.WriteLine($"{completionStatus} {goal.Description}");
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Description},{goal.IsCompleted},{goal.PointsEarned}");

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.CompletionCount);
                }
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string[] goalData = reader.ReadLine().Split(',');
                string description = goalData[0];
                bool isCompleted = bool.Parse(goalData[1]);
                int pointsEarned = int.Parse(goalData[2]);

                string type = goalData[3];
                Goal goal;

                switch (type.ToLower())
                {
                    case "simple":
                        goal = new SimpleGoal();
                        break;
                    case "eternal":
                        goal = new EternalGoal();
                        break;
                    case "checklist":
                        int targetCount = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(targetCount);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type.");
                        return;
                }

                goal.Description = description;
                goal.IsCompleted = isCompleted;
                goal.PointsEarned = pointsEarned;

                if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.CompletionCount = int.Parse(reader.ReadLine());
                }

                goals.Add(goal);
            }
        }
    }
}

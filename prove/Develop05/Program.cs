using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();

        // Example usage of the program
        goalTracker.CreateGoal("Run a marathon", "simple");
        goalTracker.CreateGoal("Read scriptures", "eternal");
        goalTracker.CreateGoal("Attend the temple", "checklist", 10);

        goalTracker.RecordGoalCompletion(0);
        goalTracker.RecordGoalCompletion(1);
        goalTracker.RecordGoalCompletion(2);
        goalTracker.RecordGoalCompletion(2);
        goalTracker.RecordGoalCompletion(2);

        goalTracker.DisplayGoals();
        goalTracker.DisplayScore();

        goalTracker.SaveGoals("goals.txt");

        // Load goals from file
        goalTracker.LoadGoals("goals.txt");
        goalTracker.DisplayGoals();
        goalTracker.DisplayScore();
    }
}

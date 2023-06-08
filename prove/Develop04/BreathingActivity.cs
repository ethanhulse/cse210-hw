class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Prepare();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Delay();
            Console.WriteLine("Breathe out...");
            Delay();
        }

        Finish("Breathing Activity");
    }

    private void Prepare()
    {
        Console.WriteLine("Get ready to begin.");
        Delay();
    }

    private void Finish(string activityName)
    {
        Console.WriteLine("Good job! You have completed the " + activityName);
        Delay();
    }

    private void Delay()
    {
        Thread.Sleep(2000);
    }
}
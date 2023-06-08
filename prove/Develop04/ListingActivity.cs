class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Prepare();

        Random random = new Random();
        for (int i = 0; i < duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Delay();

            Console.WriteLine("Begin listing...");
            Thread.Sleep(5000); // Give the user 5 seconds to list items

            Console.WriteLine("You listed 5 items."); // Replace with the actual count of items entered
            Delay();
        }

        Finish("Listing Activity");
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

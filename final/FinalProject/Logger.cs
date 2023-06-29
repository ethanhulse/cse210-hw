class Logger
{
    private List<string> log;

    public Logger()
    {
        log = new List<string>();
    }

    public void LogEvent(string logEvent)
    {
        log.Add($"{DateTime.Now}: {logEvent}");
    }

    public string GetLog()
    {
        return string.Join("\n", log);
    }
}
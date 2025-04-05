public class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to {Name} Activity!");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Starting in 3 seconds...");
        DisplaySpinner(3);
        RunActivity();
        Console.WriteLine("Great job! Activity completed.");
    }

    protected virtual void RunActivity()
    {
        Console.WriteLine("Running activity...");
    }

    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void DisplaySpinner(int seconds)
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(seconds);
        string spinnerString = "+-=/";
        int counter = 0;
        Console.Write("Waiting: ");
        while (now < future)
        {
            Thread.Sleep(100);
            Console.Write($"{spinnerString[counter % spinnerString.Length]}");
            Console.Write("\b");
            Thread.Sleep(500);
            counter++;
            now = DateTime.Now;
        }
        Console.WriteLine();
    }
}

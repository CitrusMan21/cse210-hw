class Program
{
    static void Main()
    {
        Console.WriteLine("Select an activity: 1. Breathing  2. Reflection");
        string choice = Console.ReadLine();

        Activity activity;
        if (choice == "1")
            activity = new BreathingActivity();
        else if (choice == "2")
            activity = new ReflectionActivity();
        else
        {
            Console.WriteLine("Invalid choice. Exiting...");
            return;
        }

        Console.WriteLine("Preparing your activity...");
        new Activity("", "").DisplaySpinner(3);
        activity.Start();
    }
}

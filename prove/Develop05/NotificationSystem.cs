class NotificationSystem
{
    public static void SendReminder(JobApplication application)
    {
        Console.WriteLine($"Reminder: Follow up on application for {application.Position} at {application.Company}.");
    }
}
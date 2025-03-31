public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "A relaxation exercise to help you breathe deeply.") { }

    protected override void RunActivity()
    {
        for (int i = 0; i < Duration / 5; i++)
        {
            Console.WriteLine("Breathe in...");
            DisplayCountdown(3);
            Console.WriteLine("Hold...");
            DisplayCountdown(2);
            Console.WriteLine("Breathe out...");
            DisplayCountdown(3);
        }
    }
}
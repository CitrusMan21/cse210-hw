public class ReflectionActivity : Activity
{
    private static string[] Prompts =
    {
        "Think about a time you overcame a challenge.",
        "Recall a moment when you felt truly happy.",
        "Consider a lesson you recently learned."
    };

    public ReflectionActivity() : base("Reflection", "A guided reflection exercise.") { }

    protected override void RunActivity()
    {
        Random rand = new Random();
        for (int i = 0; i < Duration / 10; i++)
        {
            Console.WriteLine(Prompts[rand.Next(Prompts.Length)]);
            DisplayCountdown(10);
        }
    }
}

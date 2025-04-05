using System;
using System.Threading;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an activity: 1. Breathing  2. Reflection  3. Quit");
            string choice = Console.ReadLine();

            if (choice == "3")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Activity activity;
            if (choice == "1")
                activity = new BreathingActivity();
            else if (choice == "2")
                activity = new ReflectionActivity();
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            Console.WriteLine("Preparing your activity...");
            new Activity("", "").DisplaySpinner(3);
            activity.Start();
            Console.WriteLine();
        }
    }
}

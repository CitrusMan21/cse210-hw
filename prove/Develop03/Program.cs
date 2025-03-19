using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a reference
        Referance referance = new Referance("Ether", 12, 27, 27);
        
        // Scripture text
        string scriptureText = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        
        // Create a Scripture object
        Scripture scripture = new Scripture(referance, scriptureText);
        
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorization!");
        Console.WriteLine("Press Enter to start hiding words...");
        Console.ReadLine();
        
        // Start the memorization process
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(3); // Hide 3 words per round
        }

        // Once all words are hidden, prompt the user to recall the scripture
        Console.Clear();
        Console.WriteLine("\nAll words are hidden! Type the scripture from memory:");
        string userInput = Console.ReadLine();

        // Grade the user's input
        double score = scripture.GradeUserInput(userInput);
        Console.WriteLine($"\nYour accuracy score: {score:F2}%");

        // Provide feedback based on the score
        if (score == 100)
            Console.WriteLine(" Perfect! You've memorized the scripture completely! ");
        else if (score >= 80)
            Console.WriteLine(" Great job! You remembered most of it correctly.");
        else if (score >= 50)
            Console.WriteLine(" You're getting there! Keep practicing.");
        else
            Console.WriteLine(" Keep working on it. You'll get better with practice!");
    }
}
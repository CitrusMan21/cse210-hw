using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("Please Enter Your First Name?: ");
        Console.WriteLine("Please Enter Your Second Name?: ");
        string FirstName = Console.ReadLine();
        string LastName = Console.ReadLine();
        Console.WriteLine($"Your Name Is {LastName}, {FirstName} {LastName}");
    }
}
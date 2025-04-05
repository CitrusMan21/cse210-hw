class CrewProfile
{
    public string UserName { get; set; }
    public string Email { get; set; }

    public CrewProfile(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }

    public void DisplayProfile()
    {
        Console.WriteLine($"User: {UserName}, Email: {Email}");
    }
}
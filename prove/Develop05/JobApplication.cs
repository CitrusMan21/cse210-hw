class JobApplication : TrackableItem
{
    public string Company { get; set; }
    public string Position { get; set; }
    public ApplicationStatus Status { get; set; }

    public JobApplication(string name, string company, string position)
    {
        Name = name;
        Company = company;
        Position = position;
        Status = ApplicationStatus.Applied;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Application: {Name}, Company: {Company}, Position: {Position}, Status: {Status}");
    }
}
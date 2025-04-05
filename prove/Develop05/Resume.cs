class Resume : TrackableItem
{
    public string FilePath { get; private set; }
    public string CoverLetter { get; private set; }
    public List<string> PreviousJobs { get; private set; } = new List<string>();

    public Resume(string name, string filePath, string coverLetter)
    {
        Name = name;
        FilePath = filePath;
        CoverLetter = coverLetter;
    }

    public void AddJob(string jobDescription)
    {
        PreviousJobs.Add(jobDescription);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Resume: {Name}, File: {FilePath}, Created: {DateCreated}");
        Console.WriteLine("Previous Jobs:");
        foreach (var job in PreviousJobs)
        {
            Console.WriteLine(" - " + job);
        }
    }

    public void SaveResume()
    {
        string directoryPath = "Resumes";
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        string resumePath = Path.Combine(directoryPath, Name.Replace(" ", "_") + ".txt");
        using (StreamWriter writer = new StreamWriter(resumePath))
        {
            writer.WriteLine($"Resume Name: {Name}");
            writer.WriteLine($"File Path: {FilePath}");
            writer.WriteLine($"Cover Letter: {CoverLetter}");
            writer.WriteLine($"Created: {DateCreated}");
            writer.WriteLine("Previous Jobs:");
            foreach (var job in PreviousJobs)
            {
                writer.WriteLine(" - " + job);
            }
        }
        Console.WriteLine($"Resume saved at: {resumePath}");
    }
}

class Resume
{
    private string _Name;
    // private string Title;

    // private int Start;

    // private int End;

    private List<Job> _jobs;



    public Resume(string name)
    {
        _Name = name;
        _jobs =new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"{_Name} resume: List of Jobs");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}
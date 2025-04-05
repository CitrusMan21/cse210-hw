class Company
{
    public string Name { get; set; }
    public List<JobApplication> JobApplications { get; private set; } = new List<JobApplication>();

    public Company(string name)
    {
        Name = name;
    }

    public void AddApplication(JobApplication job)
    {
        JobApplications.Add(job);
    }
}

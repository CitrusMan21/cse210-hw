using System;
using System.Collections.Generic;
using System.IO;

class ResumeTracker
{
    static void Main(string[] args)
    {
        List<JobApplication> applications = new List<JobApplication>();

        Console.WriteLine("Enter your username:");
        string userName = Console.ReadLine();

        Console.WriteLine("Enter your email:");
        string userEmail = Console.ReadLine();

        CrewProfile user = new CrewProfile(userName, userEmail);
        user.DisplayProfile();

        Console.WriteLine("Enter resume name:");
        string resumeName = Console.ReadLine();

        Console.WriteLine("Enter resume file path:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter cover letter text:");
        string coverLetter = Console.ReadLine();

        Resume resume1 = new Resume(resumeName, filePath, coverLetter);

        Console.WriteLine("Enter previous jobs one by one. Type 'done' to finish:");
        while (true)
        {
            string job = Console.ReadLine();
            if (job.ToLower() == "done") break;
            resume1.AddJob(job);
        }

        resume1.DisplayInfo();
        resume1.SaveResume();

        Company company1 = new Company("TechCorp");
        JobApplication job1 = new JobApplication("Software Engineer Application", "TechCorp", "Software Engineer");
        company1.AddApplication(job1);
        applications.Add(job1);

        Recruiter recruiter1 = new Recruiter("Jane Smith", "jane.smith@techcorp.com", "123-456-7890");

        ReportGenerator.GenerateReport(applications);
        NotificationSystem.SendReminder(job1);
    }
}

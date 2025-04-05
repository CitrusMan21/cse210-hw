class ReportGenerator
{
    public static void GenerateReport(List<JobApplication> applications)
    {
        Console.WriteLine("\nApplication Summary Report:");
        foreach (var app in applications)
        {
            app.DisplayInfo();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job myFirstJob = new Job("Taco Time","Ceo", 2020 ,2022);
        //myFirstJob.DisplayJob();
        Job mySecondJob = new Job("Hp Inc","Engineer", 2022 ,2025);
        //myFirstJob.DisplayJob();
        Resume myResume = new Resume("Darrin Baron");
        myResume.AddJob(myFirstJob);
        myResume.AddJob(mySecondJob);
        myResume.DisplayResume();
    }

}
using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job("Naleli", "Pharmacist", 2015, 2025);
        var job2 = new Job("AGL", "Pastor", 2021, 2025);
        var jobList = new List<Job> {job1, job2};
        var Resume = new Resume("Letlotlo Hlaoli", jobList);
        Resume.WorkExperience();
    }
}
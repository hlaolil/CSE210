using System;

class Program
{
    static void Main(string[] args)
    {
        job1 = new job()
        job1._jobTitle = "Pharmacist";
        job1._company = "Naleli";
        job1._startYear = 2015;
        job1._endYear = 2025;
        job1.JobInfo();

        job2 = new job()
        job2._jobTitle = "Pastor";
        job2._company = "AGL";
        job2._startYear = 2021;
        job2._endYear = 2025;
        job2.JobInfo();
    }
}
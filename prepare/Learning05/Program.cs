using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Business as Mission", "Letlotlo Hlaoli");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Math", "Letlotlo Hlaoli", "Chapter 5", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WrittenAssignment writtenAssignment = new WrittenAssignment("History", "Letlotlo Hlaoli", "The Rise of Civilizations");
        Console.WriteLine(writtenAssignment.GetSummary());
        Console.WriteLine(writtenAssignment.GetWritingInfo());

    }
}

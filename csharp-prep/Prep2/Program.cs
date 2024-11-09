using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = "";
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 90)
        {
            grade = "A";
        }  
        else if (percentage >= 80)
        {
           grade = "B";
        }
        else if (percentage>= 70)
        {
            grade= "C";
        }
        else if (percentage>= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is {grade}");
        if (grade == "A" || grade == "B" || grade == "C")
        {
            Console.WriteLine("Congratulations, You have Passed");
        }
        else 
        {
            Console.WriteLine("Sorry, you have not passed, try harder next time");
        }

    }
}

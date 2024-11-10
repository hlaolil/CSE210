using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        Console.WriteLine("Enter a series of numbers and enter 0 when finished");
        while (true) 
        {
            Console.WriteLine("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
                break;
            numbersList.Add(number);
        }
        int sum = 0;
        foreach (int num in numbersList)
            {
                sum += num;
            }
        int avrg = numbersList.Count > 0 ? sum / numbersList.Count : 0;
        int smallest = numbersList.Min();
        int biggest = numbersList.Max();
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average is: {avrg} ");
        Console.WriteLine($"The samllest number is: {smallest}");
        Console.WriteLine($"The Biggets number is: {biggest}");
    }
}
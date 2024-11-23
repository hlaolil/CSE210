using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        // Default constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction1: {fraction1.GetFractionString()}"); // Output: 1/1
        Console.WriteLine($"Fraction1: {fraction1.GetDecimalValue()}"); // Output: 1

        // Single-parameter constructor
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction2: {fraction2.GetFractionString()}"); // Output: 5/1
        Console.WriteLine($"Fraction2: {fraction2.GetDecimalValue()}"); // Output: 5

        // Two-parameter constructor
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction3: {fraction3.GetFractionString()}"); // Output: 3/4
        Console.WriteLine($"Fraction3: {fraction3.GetDecimalValue()}"); // Output: 0.75

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction3: {fraction4.GetFractionString()}"); // Output: 1/3
        Console.WriteLine($"Fraction3: {fraction4.GetDecimalValue()}"); // Output: 0.33
    }
}
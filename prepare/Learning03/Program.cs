using System;

public class Program
{
    public static void Main(string[] args)
    {
    // Displays the first fraction
        Fraction fraction1 = new Fraction(); // Whole number 
        Console.WriteLine(fraction1.GetFractionString()); // Fraction form
        Console.WriteLine(fraction1.GetDecimalValue()); // Decimal form

    // Displays the second fraction 
        Fraction fraction2 = new Fraction(5); // Whole number
        Console.WriteLine(fraction2.GetFractionString()); // Fraction form
        Console.WriteLine(fraction2.GetDecimalValue()); // Decimal form

    // Displays the third fraction
        Fraction fraction3 = new Fraction(3, 4); // Fraction
        Console.WriteLine(fraction3.GetFractionString()); // Fraction form
        Console.WriteLine(fraction3.GetDecimalValue()); // Decimal form

    // Displays the fourth fraction
        Fraction fraction4 = new Fraction(1, 3); // Fraction
        Console.WriteLine(fraction4.GetFractionString()); // Fraction form
        Console.WriteLine(fraction4.GetDecimalValue()); // Decimal form
    }
}

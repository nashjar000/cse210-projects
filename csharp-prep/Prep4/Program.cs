using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Ask user for numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        do
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);
        }
        while (input != 0);

        // Compute sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Compute average
        double average = (double)sum / (numbers.Count - 1);

        // Find maximum
        int maximum = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
    }
}
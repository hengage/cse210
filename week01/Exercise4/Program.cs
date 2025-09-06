using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            
            if (int.TryParse(userInput, out int number))
            {
                if (number == 0)
                    break;
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            Console.WriteLine($"The sum is: {CalculateSum(numbers)}");
            Console.WriteLine($"The average is: {CalculateAverage(numbers)}");
            Console.WriteLine($"The largest number is: {FindMaxNumber(numbers)}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }

    static int CalculateSum(List<int> numbers)
    {
        return numbers.Sum();
    }

    static double CalculateAverage(List<int> numbers)
    {
        return numbers.Average();
    }

    static int FindMaxNumber(List<int> numbers)
    {
        return numbers.Max();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");

        string gradePercentage = Console.ReadLine();

        string letter = "";
        if (int.TryParse(gradePercentage, out int numericValue) == false)
        {
            Console.WriteLine("Please enter a valid number between 0 and 100.");
            return;
        }
        if (numericValue >= 90)
        {
            letter = "A";
        }
        else if (numericValue >= 80)
        {
            letter = "B";
        }
        else if (numericValue >= 70)
        {
            letter = "C";
        }
        else if (numericValue >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is a {letter}.");
        determinePassFail(numericValue);

    }

    static void determinePassFail(int gradePercentage)
    {
        if (gradePercentage > 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. With more effort, you can do better next time.");
        }
    }
}
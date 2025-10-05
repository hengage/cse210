using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ngozi Okafor", "Half Into Oblivion");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("Chinedu Eze", "Further Mathematics", "3.2", "15-25");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment("Amina Bello", "Literature", "The slip");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
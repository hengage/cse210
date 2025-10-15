using ExerciseTracking;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Running run1 = new Running("10/16/2025", 30, 5.2);

        Cycling cycle1 = new Cycling("10/11/2025", 60, 25);

        Swimming swim1 = new Swimming("10/09/2025", 45, 30);

        List<Activity> activities = new List<Activity>(){run1, cycle1, swim1};
      

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.getSummary());
        }
    }
}
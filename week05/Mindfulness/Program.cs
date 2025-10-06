// Creative Addtions
    // Loaded the promts from csv files to make it easier to add more prompts/questions
    // and to separate data from code

    // Added a FileHandler class to handle file reading operations
    
    // Created ab activity logger to log completed activities to a text file


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectingActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") ActivityLogger.DisplayActivityCounts();
            else if (choice == "5") break;
            else Console.WriteLine("Invalid choice. Try again.");
        }
    }

    static void ChooseActivity()
    {

    }
}

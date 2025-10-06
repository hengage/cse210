// Creative Addtions
    // Loaded the promts from csv files to make it easier to add more prompts/questions
    // and to separate data from code


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
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ReflectingActivity().Run();
            else if (choice == "3") new ListingActivity().Run();
            else if (choice == "4") break;
            else Console.WriteLine("Invalid choice. Try again.");
        }
    }

    static void ChooseActivity()
    {

    }
}

// Creative Additions
// Used a combination of while loop and FileNotFoundException to handle file loading more gracefully.
// Users can now attempt to load a file multiple times if they initially enter an incorrect filename,
// without crashing the program. This improves user experience by allowing error correction on the fly.

// Optimized to handle both txt and CSV files

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        Console.WriteLine("\nWelcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now,
                        _promptText = prompt,
                        _entryText = response
                    };
                    theJournal.AddEntry(entry);
                    break;

                case "2":
                    Console.WriteLine("\nJournal Entries:");
                    Console.WriteLine("");
                    theJournal.DisplayEntries();
                    break;

                case "3":

                    theJournal.LoadFromFile();
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "4":

                    theJournal.SaveToFile();
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
}
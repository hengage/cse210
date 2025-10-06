public class ListingActivity : Activity
{
    private List<string> _prompts;
    private FileHandler _fileHandler = new FileHandler();
    // private List<string> _prompts = new List<string>
    // {
    //     "Who are people that you appreciate?",
    //     "What are personal strengths of yours?",
    //     "Who are people that you have helped this week?",
    //     "When have you felt the Holy Ghost this month?",
    //     "Who are some of your personal heroes?"
    // };


    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = _fileHandler.LoadFromCsv("listing_prompts.csv");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();
        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) items.Add(input);
        }
        return items;
    }
}

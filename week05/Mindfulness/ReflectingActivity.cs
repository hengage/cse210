public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private FileHandler _fileHandler = new FileHandler();

    public ReflectingActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience."
    )
    {
        _prompts = _fileHandler.LoadFromCsv("reflection_prompts.csv");
        _questions = _fileHandler.LoadFromCsv("reflection_questions.csv");
    }

    public void Run()
    {
    DisplayStartingMessage();
    
    // Display the initial prompt and give time to ponder
    Console.WriteLine("\nConsider the following prompt:");
    Console.WriteLine("\n--- " + GetRandomPrompt() + " ---");
    Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
    Console.ReadLine();
    
    Console.WriteLine("\nNow ponder each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
        Console.WriteLine("\n> " + GetRandomQuestion());
        ShowSpinner(3);
    }

    DisplayEndingMessage();
}

    private string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Count)];
    private string GetRandomQuestion() => _questions[new Random().Next(_questions.Count)];
}

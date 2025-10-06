public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();
        int elapsed = 0;
        while (elapsed < GetDuration())
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            elapsed += 10;
        }
        DisplayEndingMessage();
    }
}

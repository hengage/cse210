
class PromptGenerator
{
    private string[] prompts = {
        "What are you feeling grateful for in this moment?",
        "What challenges are you currently facing?",
        "What goal would you like to accomplish today?",
        "What success have you experienced so far today?",
        "What have you learned in the past few hours?",
        "What is bringing you joy right now?",
        "What positive habit would you like to start today?",
        "Who is inspiring you at this present moment?",
        "Where would you most like to be right now and why?",
        "What fills you with gratitude in this moment?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
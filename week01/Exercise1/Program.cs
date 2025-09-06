using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine(
            $"Your name is {textInfo.ToTitleCase(lastName)}, {textInfo.ToTitleCase(firstName)} {textInfo.ToTitleCase(lastName)}."
            );
    }
}
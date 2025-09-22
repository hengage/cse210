// CREATIVE ADDITIONS:
    // - Scripture loading from an external file (scriptures.txt) using flexible formats
    // - Supports both single-verse (Book|Chapter|Verse|Text) and multi-verse (Book|Chapter|StartVerse|EndVerse|Text) entries.
    // - Random selection of scripture from a large library for variety.
    // - Dynamically determine the number of words to hide based on the total word count.
    // - Prevents hiding words that are already hidden.

class Program
{
    static void Main(string[] args)
    {
        string filePath = "scriptures.txt";
        List<Scripture> scriptures = Scripture.LoadFromFile(filePath);

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            ;

            if (!scripture.AllWordsHidden())
            {
                scripture.HideRandomWords();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int userNumber;

        do 
        {
            Console.Write("Enter a number between 1 and 100: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out userNumber) == false)
            {
                Console.WriteLine("Please enter a valid number between 1 and 100.");
                continue;
            }

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Your number is too high.");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Your number is too low.");
            }
            
        } while (userNumber != randomNumber);

        Console.WriteLine("Congratulations! You guessed the correct number.");
    }
}
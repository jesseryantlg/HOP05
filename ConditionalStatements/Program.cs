internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1; 

        Console.WriteLine("Guess a number (1 - 10): "); 
        int userInput = Convert.ToInt32(Console.ReadLine()); //receieve user input and store in "userInput" variable

        if (userInput == num)
        {
            Console.WriteLine("Your guess was correct!");
        }
        else if(userInput != num)
        {
            Console.WriteLine("You guessed wrong. Good luck next time.");
        }
    }
}
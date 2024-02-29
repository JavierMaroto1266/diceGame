// This program simulates a simple dice game between the player and an AI opponent.

internal class Program
{
    private static void Main(string[] args)
    {
        // Declare variables to store game information
        int playerRandomNum;
        int enemyRandomNum;
        int playerPoints = 0;
        int enemyPoints = 0;

        // Create a Random object to generate random numbers
        Random random = new Random();

        // Greeting message
        Console.WriteLine("Welcome to diceGame!");


        // Start the game loop for 10 rounds
        for (int i = 0; i < 5; i++)
        {
            // Prompt the player to roll the dice
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any key to roll the dice!");
            Console.ResetColor();
            Console.ReadKey();

            // Generate a random number for the player's roll (1-6)
            playerRandomNum = random.Next(1, 7);

            // Display the player's roll
            Console.WriteLine("You rolled a: " + playerRandomNum);
            Console.ReadKey();

            // Simulate a short delay to build suspense
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(600);

            // Generate a random number for the enemy's roll (1-6)
            enemyRandomNum = random.Next(1, 7);

            // Display the enemy's roll
            Console.WriteLine("Enemy AI rolled a: " + enemyRandomNum);

            // Determine the winner of the round
            if (playerRandomNum > enemyRandomNum)
            {
                playerPoints++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Player wins this round!");
                Console.ResetColor();
                
            }
            else if (enemyRandomNum > playerRandomNum)
            {
                enemyPoints++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("AI wins this round!");
                Console.ResetColor();
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The game is a draw!");
                Console.ResetColor();
                
            }

            // Display the current score
            Console.WriteLine("The score is now - Player: " + playerPoints + " Enemy: " + enemyPoints);
            Console.WriteLine();
        }

        // Determine the overall winner
        if (playerPoints > enemyPoints)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You Win!");
            Console.ResetColor();
        }        else if (enemyPoints > playerPoints)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AI Wins!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("It's a draw!");
            Console.ResetColor();
        }

        // Wait for the user to press any key before closing the program
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Thank you for playing diceGame!");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Press any key to close!");
        Console.ResetColor();

        Console.ReadKey();
    }
}
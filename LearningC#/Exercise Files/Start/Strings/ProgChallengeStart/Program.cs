using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            
            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
            
            // Keep track of the number of guesses and the current user guess
            int numOfGuesses = 0;
            int userGuess;
            bool success = int.TryParse(Console.ReadLine(), out userGuess);
            numOfGuesses++;
            
            // Start the game and run until user quits or guesses correctly
            
            while (!success || (success && userGuess != theNumber && userGuess != -1)) {
              if (!success) {
                Console.WriteLine("Hmmmm... that doesn't look like a number. Try again.");
              }
              else if (userGuess < theNumber) {
                Console.WriteLine("Nope, higher than that.");
              }
              else {
                Console.WriteLine("Nope, lower than that.");
              }
              Console.WriteLine("What's your guess?");
              success = int.TryParse(Console.ReadLine(), out userGuess);
              numOfGuesses++;
            }
            
            if (userGuess == -1) {
              Console.WriteLine($"The number was {theNumber}. I'm sure you'll do better next time!");
            }
            else {
              Console.WriteLine($"The number was {theNumber}. You got it in {numOfGuesses} guesses!!");              
            }
        }
    }
}
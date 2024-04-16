using PenduConsole;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        gameEngine game = new gameEngine();


        while (game.canPlay)
        {


            Console.WriteLine("Guess the word!");
            Console.WriteLine("You have " + (game.maxWrongGuesses - game.wrongGuesses) + " guesses left.");
            Console.WriteLine("Current status: " + game.getMaskedWord());
            Console.WriteLine("Enter your guess: ");
            char guess = Console.ReadLine().ToLower()[0];

            if (game.checkGuess(guess) == false)
            {
                Console.WriteLine("Incorrect!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

        if (game.canPlay == false && game.isLose)
        {
            Console.WriteLine("You lose! The word was: " + game.word);
            Console.ReadLine();
        }
        else if (game.canPlay == false && game.isWin)
        {
            Console.WriteLine("Congratulations! You win !  The word was: " + game.word);
            Console.ReadLine();
        }
    }
}
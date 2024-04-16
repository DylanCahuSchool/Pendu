using PenduConsole;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Player p1 = new Player("Player 1", 6);
        Player p2 = new Player("Player 2", 6);
        Player[] players = { p1, p2 };
        gameEngine game = new gameEngine(players);

        while (game.CanPlay)
        {
            Console.WriteLine("Guess the word!");
            Console.WriteLine(game.getActivePlayer().getName() +", you have " + game.getActivePlayer().getLife()  + " guesses left.");
            Console.WriteLine("Current status: " + game.getMaskedWord());
            Console.WriteLine(game.getActivePlayer().getName() + ". Enter your guess: ");
            string guess = Console.ReadLine();

            if (game.checkGuess(guess) == false)
            {
                Console.WriteLine("Incorrect!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

        if (game.CanPlay == false && game.IsLose)
        {
            Console.WriteLine("You lose! The word was: " + game.getWord());
            Console.ReadLine();
        }
        else if (game.CanPlay == false && game.IsWin)
        {
            Console.WriteLine("Congratulations! You win !  The word was: " + game.getWord());
            Console.ReadLine();
        }
    }
}
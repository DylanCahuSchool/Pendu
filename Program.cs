namespace PenduConsole
{
    class Program
    {
        static void Main()
        {

            Player p = new HumanPlayer("Player", 6);
            Player ia = new IAPlayer("IlaPété", 6);
            Player[] players = { p, ia };
            gameEngine game = new gameEngine(players);

            while (game.CanPlay)
            {
                Console.WriteLine("Guess the word!");
                Console.WriteLine(game.getActivePlayer().getName() +", you have " + game.getActivePlayer().getLife()  + " guesses left.");
                Console.WriteLine("Current status: " + game.getMaskedWord());
                Console.WriteLine(game.getActivePlayer().getName() + ". Enter your guess: ");

                /*

                if (game.checkGuess(guess) == false)
                {
                    Console.WriteLine("Incorrect!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }
            }*/

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
    }
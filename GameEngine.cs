using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenduEnMieux
{
    public class GameEngine
    {

        public static int wrongGuesses = 0;
        public static int maxWrongGuesses = 6;
        public static int goodGuessesCount;
        public static string word = getStartWord();

        public static string getStartWord()
        {
            return "test";
        }

        public static void checkGuess(char guess)
        {
            if (word.Contains(guess))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        Program.form1.Display(i, guess);
                        goodGuessesCount++;
                    }
                }

                if (goodGuessesCount == word.Length)
                {
                    Program.form1.win();
                }
            }
            else
            {
                wrongGuesses++;
                MessageBox.Show("Incorrect!");

                if (wrongGuesses == maxWrongGuesses)
                {
                    Program.form1.lose();
                }
            }
        }

    }
}

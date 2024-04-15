using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenduEnMieux
{
    public class GameEngine
    {

        public int wrongGuesses = 0;
        public int maxWrongGuesses = 6;
        public int goodGuessesCount;
        public string word = getStartWord();

        public static string getStartWord()
        {
            return "test";
        }

        public bool checkGuess(char guess)
        {
            if (word.Contains(guess))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
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
            return word.Contains(guess);
        }

    }
}

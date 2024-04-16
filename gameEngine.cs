using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PenduConsole
{
    public class gameEngine
    {
        //public int wrongGuesses = 0;
        //public int maxWrongGuesses = 6;
        public int goodGuessesCount;
        private string word;
        private bool[] guessedLetters;
        public bool isWin = false;
        public bool isLose = false;
        public bool canPlay = true;
        public int activePlayerIndex = 0;
        Player[] players = new Player[1];

        // Constructor
        public gameEngine(Player[] addPlayers)
        {
            word = getStartWord();
            guessedLetters = new bool[word.Length];
            foreach (Player player in addPlayers)
            {
                Array.Resize(ref players, players.Length + 1);
            }
        }

        public Player getActivePlayer()
        {
            return players[activePlayerIndex];
        }

        private void switchPlayer()
        {
            activePlayerIndex++;
            if (activePlayerIndex >= players.Length)
            {
                activePlayerIndex = 0;
            }
        }

        public string getWord() 
        {
            return word;
        }

        public string getStartWord()
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
                        guessedLetters[i] = true;
                    }
                }

                if (goodGuessesCount == word.Length)
                {
                    canPlay = false;
                    isWin = true;
                }
            }
            else
            {
                wrongGuesses++;

                if (wrongGuesses == maxWrongGuesses)
                {
                    canPlay = false;
                    isLose = true;
                }
            }
            switchPlayer();
            return word.Contains(guess);
        }

        public string getMaskedWord()
        {
            string maskedWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    maskedWord += " ";
                }
                else
                {
                    if (guessedLetters[i])
                    {
                        maskedWord += word[i];
                    }
                    else
                    {
                        maskedWord += "#";
                    }
                }
            }
            return maskedWord;
        }
    }
}
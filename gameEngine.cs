namespace PenduConsole
{
    public class gameEngine
    {
        public int GoodGuessesCount { get; private set; }
        private string word;
        private bool[] guessedLetters;
        public bool CanPlay { get; private set; } = true;
        public bool IsWin { get; private set; } = false;
        public bool IsLose { get; private set; } = false;
        public int ActivePlayerIndex { get; private set; } = 0;
        private Player[] players;

        // Constructor
        public gameEngine(Player[] addPlayers)
        {
            word = getStartWord();
            guessedLetters = new bool[word.Length];
            players = addPlayers;
        }

        public Player getActivePlayer()
        {
            return players[ActivePlayerIndex];
        }

        public bool activePlayerHasLife()
        {
            return getActivePlayer().getLife() > 0;
        }

        private void switchPlayer()
        {
            ActivePlayerIndex++;
            if (ActivePlayerIndex >= players.Length -1)
            {
                ActivePlayerIndex = 0;
            }
            if (activePlayerHasLife() == false)
            {
                int cptPerdant=0;

                for (int i=0 ; i < players.Length -1; i++)
                {
                    if(players[i].getLife() == 0)
                    {
                        cptPerdant++;
                    }
                }
                if (cptPerdant == players.Length-1)
                {
                    Lose();
                }
                else
                {
                    switchPlayer();
                }
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

        public bool checkGuess(string guess)
        {
            if (guess == "")
            {
                getActivePlayer().decreaseLife();
                switchPlayer();
                return false;
            }
            if (word.Contains(guess.ToLower()[0]))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess.ToLower()[0])
                    {
                        if (guessedLetters[i] == true)
                        {
                            return true;
                        }
                        else
                        {
                            GoodGuessesCount++;
                            guessedLetters[i] = true;
                        }
                    }
                }

                if (GoodGuessesCount == word.Length)
                {
                    Win();
                }
            }
            else
            {
                getActivePlayer().decreaseLife();
            }

            switchPlayer();
            return word.Contains(guess);
        }

        public void Win()
        {
            CanPlay = false;
            IsWin = true;
        }

        public void Lose()
        {
            CanPlay = false;
            IsLose = true;
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
namespace PenduConsole
{
    public class IAPlayer : Player
    {
        public IAPlayer(string name, int life) : base(name, life)
        {

        }

        public override char ChooseLetter()
        {
            char letter = 't';
            return letter;
        }
    }
}

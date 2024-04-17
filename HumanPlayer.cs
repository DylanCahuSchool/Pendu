namespace PenduConsole
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, int life) : base(name, life)
        {
        }

        public override char ChooseLetter()
        {
            Console.WriteLine("Entrez une lettre : ");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return letter;
        }
    }
}

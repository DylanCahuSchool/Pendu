namespace PenduConsole
{
    public abstract class Player
    {
        protected string name;
        protected int life;

        public Player(string name, int life)
        {
            this.name = name;
            this.life = life;
        }

        public string getName()
        {
            return name;
        }

        public int getLife()
        {
            return life;
        }

        public void decreaseLife()
        {
            life--;
        }

        public abstract char ChooseLetter();
    }
}

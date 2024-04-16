using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PenduConsole
{
    public class Player
    {
        private string name;
        private int life;

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
    }
}

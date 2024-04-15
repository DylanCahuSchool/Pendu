namespace PenduEnMieux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < GameEngine.word.Length; i++)
            {
                TextBox entry = new TextBox();
                entry.Location = new Point(10 + i * 20, 10);
                entry.Name = "entry" + i.ToString();
                entry.Size = new Size(20, 20);
                entry.Enabled = false;
                entry.BackColor = Color.Black;
                this.Controls.Add(entry);
            }

            //guess textbox on the bottom
            TextBox guess = new TextBox();
            guess.Name = "guess";
            guess.Location = new Point(10, 100);
            guess.Size = new Size(20, 20);
            this.Controls.Add(guess);

            //create a new button "guessButton"
            Button guessButton = new Button();
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(100, 50);
            guessButton.Location = new Point(30, 100);
            guessButton.Text = "Try";
            guessButton.Click += new EventHandler(guessButton_Click);
            this.Controls.Add(guessButton);


        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            char guessChar;
            try
            {
                guessChar = this.Controls.Find("guess", true)[0].Text[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid character!");
                return;
            }


            for(int i = 0; i < GameEngine.word.Length; i++)
            {
                if (GameEngine.word[i] == guessChar)
                {
                    Control c = this.Controls.Find("entry" + i.ToString(), true)[0];
                    c.Text = guessChar.ToString();
                    c.BackColor = Color.White;
                }
            }

            GameEngine.checkGuess(guessChar);

            //reset the guess textbox
            this.Controls.Find("guess", true)[0].Text = "";
 
        }

        public void win()
        {
            MessageBox.Show("You won!");
            Application.Restart();
           
        }

        public void lose()
        {
            MessageBox.Show("You lost!");
            Application.Restart();

        } 
    }
}

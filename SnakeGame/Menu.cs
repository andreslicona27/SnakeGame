namespace SnakeGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void animationTimer_Tick(object sender, EventArgs e)
        {
        // Add code when I figure what type of animation I can do for the title 

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHSTable_Click(object sender, EventArgs e)
        {
            Scores s = new Scores();
            s.ShowDialog();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.ShowDialog();
        }
        private void btnApples_Click(object sender, EventArgs e)
        {
            HowToPlay hp = new HowToPlay();
            hp.ShowDialog();
        }

    

    }
}
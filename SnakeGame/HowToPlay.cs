using SnakeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class HowToPlay : Form
    {
        //Dictionary<String, String> applesInfo = new Dictionary<String, String>() 
        //{
        //    {"Normal", "Increase the body and the speed by one unit"},
        //    {"Triple", "Increase the body and the speed by three unit"},
        //    {"Revive", "It gives you another chance on the running game, it can only apear one time per game"},
        //    {"Toxic", "Kills the snake immediately, so in other words its Game Over"},
        //    {"Golden", "Gives you 250 points, but it may only apear once in a life time"},
        //};

        Image[] appleImage = {
            global::SnakeGame.Properties.Resources.apple,
            global::SnakeGame.Properties.Resources.apple,
            global::SnakeGame.Properties.Resources.apple,
            global::SnakeGame.Properties.Resources.apple,
            global::SnakeGame.Properties.Resources.apple
        };
        string[] applesName = {"Normal", "Triple", "Revive", "Toxic", "Golden"};
        string[] applesDescription = { "Increase the body and the speed by one unit",
            "Increase the body and the speed by three unit",
            "It gives you another chance on the running game, it can only apear one time per game",
            "Kills the snake immediately, so in other words its Game Over",
            "Gives you 250 points, but it may only apear once in a life time"};

        public HowToPlay()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PictureBox pbAppleImage;
        private Label lblAppleName;
        private Label lblAppleDescription;
        private void HowToPlay_Load(object sender, EventArgs e)
        {
            int pictureLocationX = 50;
            int pictureLocationY = 250;

            int titleLocationX = 150;
            int titleLocationY = 250;

            int descriptionLocationX = 150;
            int descriptionLocationY = 275;

            for (int i = 0; i < applesName.Length; i++)
            {
                // APPLE IMAGE PROPERTIES
                pbAppleImage = new PictureBox();
                pbAppleImage.Parent = panelInstructions;
                pbAppleImage.Image = global::SnakeGame.Properties.Resources.apple;
                pbAppleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbAppleImage.Size = new Size(60, 60);
                pbAppleImage.Location = new Point(pictureLocationX, pictureLocationY);


                // APPLE NAME PROPERTIES
                lblAppleName = new Label();
                lblAppleName.Parent = panelInstructions;
                lblAppleName.Location = new Point(titleLocationX, titleLocationY);
                lblAppleName.AutoSize = true;
                lblAppleName.Text = applesName[i];
                lblAppleName.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                // APPLE DESCRIPTION PROPERTIES
                lblAppleDescription = new Label();
                lblAppleDescription.Parent = panelInstructions;
                lblAppleDescription.Location = new Point(descriptionLocationX, descriptionLocationY);
                lblAppleDescription.Size = new Size(250, 30);
                lblAppleDescription.Text = applesDescription[i];
                lblAppleDescription.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                // POSITIONING
                pictureLocationY += 90;
                titleLocationY += 90;
                descriptionLocationY += 90;

            }
        }
    }
}

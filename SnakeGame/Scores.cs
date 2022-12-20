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
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("userprofile");

            try
            {
                using(StreamReader sr = new StreamReader(path + "\\Scores.txt"))
                {

                }

            }
            catch (DirectoryNotFoundException)
            {

            }
            catch (IOException)
            {

            }
            catch (Exception)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodFight_SathurshanA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnStart_Click
            //Purpose: to bring user to next form where it asks for their name

            Username AskName = new Username();
            this.Hide();
            AskName.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnInstructions_Click
            //Purpose: Opens instructions for the user
            Instructions Explain = new Instructions();
            this.Hide();
            Explain.Show();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnHighScores_Click
            //Purpose: Opens the highscores form for the user

            HighScores Scores = new HighScores();
            this.Hide();
            Scores.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnExit_Click
            //Purpose: Exits the whole application

            Application.Exit();
        }
    }
}

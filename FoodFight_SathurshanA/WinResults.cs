using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoodFight_SathurshanA
{
    public partial class WinResults : Form
    {
        //Global Variables 
        public static string strUserName;
        public static int intFinalScore;

        public WinResults()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 5, 2020
            //Title: btnPlayAgain_Click
            //Purpose: Allows the player to play again

            FoodFight Game = new FoodFight();
            this.Hide();
            Game.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 5, 2020
            //Title: btnReturn_Click
            //Purpose: To return to the main menu

            Menu MainMenu = new Menu();
            this.Hide();
            MainMenu.Show();
        }

        private void WinResults_Load(object sender, EventArgs e)
        {

            //Name: Sathurshan Arulmohan
            //Date: July 5, 2020
            //Title: WinResults_Load
            //Purpose: Adds the username and score to the highscore file 

            //Display the Final score
            this.lblFinalScore.Text = intFinalScore.ToString();

            //Open the highscore file
            StreamReader re = File.OpenText("HighScores.txt");

            //Copy all the info in the file
            string strRead = re.ReadToEnd();

            //Close the file
            re.Close();
            
            FileInfo t = new FileInfo("HighScores.txt");
            StreamWriter Tex = t.CreateText();

            //Write the copies info AND the new info 
            Tex.WriteLine(strRead);
            Tex.Write(strUserName + "," + intFinalScore.ToString());

            //Closes the file
            Tex.Close();
        }
    }
}

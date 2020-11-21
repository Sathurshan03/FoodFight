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
    public partial class Username : Form
    {

        public Username()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnReturn_Click
            //Purpose: Returns to the main menu

            Menu MainMenu = new Menu();
            this.Hide();
            MainMenu.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnStart_Click
            //Purpose: starts the game

            //Sends the username to WinResults form so that the username can be saved with their score at the end of the game
            WinResults.strUserName = this.txtUserName.Text;

            //Brings to the game form
            FoodFight Game = new FoodFight();
            this.Hide();
            Game.Show();
        }
    }
}

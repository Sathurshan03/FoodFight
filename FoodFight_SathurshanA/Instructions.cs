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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnReturn_Click
            //Purpose: To return to main menu

            Menu MainMenu = new Menu();
            this.Hide();
            MainMenu.Show();
        }
    }
}

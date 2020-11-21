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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: btnReturn_Click
            //Purpose: To return back to main menu

            Menu MainMenu = new Menu();
            this.Hide();
            MainMenu.Show();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: July 3, 2020
            //Title: HighScores_Load
            //Purpose: To display the top 10 highscores

            //Variables
            string strInput = null;
            string strTemp;
            int intTemp;
            int intCounter = 0;

            //Arrays
            string[] strUserName;
            int[] intUserScore;

            //Opens file with data
            StreamReader re = File.OpenText("HighScores.txt");

            //Count the number of data in file
            while ((strInput= re.ReadLine()) != null)
            {
                intCounter++;
            }
            re.Close();

            //Resize array to number of data
            strUserName = new string[intCounter];
            intUserScore = new int[intCounter];

            re = File.OpenText("HighScores.txt");

            //Read the info and put into array
            for(int i = 0; i < intCounter; i++)
            {
                strInput = re.ReadLine();
                strUserName[i] = strInput.Substring(0, strInput.IndexOf(","));

                intUserScore[i] = Int32.Parse(strInput.Substring(strInput.IndexOf(",") + 1, strInput.Length - strInput.IndexOf(",") - 1));    
            }
            re.Close();

            //Sort by decreasing scores
            for(int j = 0; j < intCounter; j++)
            {
                for (int k = 0; k < intCounter -1; k++)
                {
                    if(intUserScore[k]< intUserScore[k+1])
                    {
                        intTemp = intUserScore[k];
                        intUserScore[k] = intUserScore[k + 1];
                        intUserScore[k + 1] = intTemp;

                        strTemp = strUserName[k];
                        strUserName[k] = strUserName[k + 1];
                        strUserName[k + 1] = strTemp;
                    }
                }
            }

            //Output of first 10 values in array
            for (int l = 0; l < 10; l++)
            {
                this.lblName.Text +=  strUserName[l] + "\n";
                this.lblScores.Text +=  intUserScore[l].ToString() + "\n";
            }
        }

    }
}

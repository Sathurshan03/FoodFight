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
    public partial class FoodFight : Form
    {
        public FoodFight()
        {
            InitializeComponent();
        }
        //Global arrays 
        int intRocketSpeed = 10;
        PictureBox[] pcbLazer = new PictureBox[48];
        PictureBox[] pcbObstacles = new PictureBox[15];
        Boolean[] boolObstaclePicture = new Boolean[15];
        Boolean[] boolObstacleActive = { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        Boolean[] boolLazerActive = new bool[48];
        int[] intAngle = new int[15];
        int[] intDirection = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,2,2,2,2,2 };
        int[] intObstacleSpeed = new int[15];
        int[] intHitPoints = new int[15];

        //Global variables
        int intHealth = 200;
        int intScore = 0;
        int intMinRandom = 1;
        int intAddObstacleSpeed = 0;
        int intAddLazerDamage = 0;
        int intAddObstacleHitPoints = 0;

        Random rndGenerator = new Random();

        private void Form_FoodFight_KeyDown(object sender, KeyEventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: Form_FoodFight_KeyDown
            //Purpose: Allows the user to control the rocket

            //When user presses key "W" the rocket will go up, but will not pass top of form
            if (e.KeyCode == Keys.W && this.pcb_Rocket.Top > 0)
            {
                this.pcb_Rocket.Top -= intRocketSpeed;
            }

            //When user presses key "S" the rocket will go down, but will not pass bottom border
            else if (e.KeyCode == Keys.S && this.pcb_Rocket.Bottom< this.pcbBorder.Top)
            {
                this.pcb_Rocket.Top += intRocketSpeed;
            }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: btnPlayGame_Click
            //Purpose: Officially start the game

            //Hide the button once clicked
            this.btnPlayGame.Visible = false;

            PictureBoxArrays();

            //Enable Timer to start the game
            tmr_Game.Enabled = true;

            //sets all the boolean in array to true
            for (int i = 0; i < 48; i++)
            {
                boolLazerActive[i] = true;
            }

        }
        public void PictureBoxArrays()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: Lazer
            //Purpose: Creates picture box arrays

            //Arrays for Lazer
            for (int i = 0; i < 48; i++)
            {
                pcbLazer[i] = new PictureBox();
                pcbLazer[i].Location = new Point(140 -15 * i, this.pcb_Rocket.Top + this.pcb_Rocket.Height / 2);
                pcbLazer[i].Size = new Size(10, 10);
                pcbLazer[i].Name = "Lazer"+ i;
                pcbLazer[i].BackColor = Color.Red;
                Controls.Add(pcbLazer[i]);
            }

            //Arrays for all obstacles
            for (int j = 0; j < 15; j++)
            {
                pcbObstacles[j] = new PictureBox();
                pcbObstacles[j].Location = new Point(this.Width,j*30);
                pcbObstacles[j].Size = new Size(40, 40);
                pcbObstacles[j].Name = "Obstacle" + j;
                pcbObstacles[j].BackgroundImageLayout = ImageLayout.Stretch;
                Controls.Add(pcbObstacles[j]);
            }


            ChooseFoodObstacle();
        }
        public void ChooseFoodObstacle()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: ChooseFoodObstacle
            //Purpose:Choose the food obstacle that will run

            int intPicture;
            
            //Assign a picture for 15 pictureboxes
            for (int i = 0; i < 15; i++)
            {
                if (boolObstaclePicture[i] == false)
                {
                    //Generate a random number
                    intPicture = rndGenerator.Next(intMinRandom, 109);
                    
                    //No picture(To make the game easy at beginning, and then twoars end of game, this will not generate at all)
                    if (intPicture >= intMinRandom && intPicture <= 40)
                    {
                        intObstacleSpeed[i] = 3 + intAddObstacleSpeed;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                        intHitPoints[i] = 0;
                        pcbObstacles[i].BackgroundImage = null;
                    }
                    //Fries
                    else if (intPicture >= 41 && intPicture <= 57)
                    {
                        pcbObstacles[i].BackgroundImage = Pictures.Fries;
                        intObstacleSpeed[i] = 4 + intAddObstacleSpeed;
                        intHitPoints[i] = 1 + intAddObstacleHitPoints;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                      
                    }
                    //Burger
                    else if (intPicture >= 58 && intPicture <= 70)
                    {
                        pcbObstacles[i].BackgroundImage = Pictures.Burger;
                        intObstacleSpeed[i] = 3 + intAddObstacleSpeed;
                        intHitPoints[i] = 2 + intAddObstacleHitPoints;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 30;
                        
                    }
                    //Pizza
                    else if (intPicture >= 71 && intPicture <= 82)
                    {
                        pcbObstacles[i].BackgroundImage = Pictures.Pizza;
                        intObstacleSpeed[i] = 2 + intAddObstacleSpeed;
                        intHitPoints[i] = 4 + intAddObstacleHitPoints;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                       
                    }
                    //Milshake
                    else if (intPicture >= 83 && intPicture <= 93)
                    {
                        pcbObstacles[i].BackColor = Color.White;
                        pcbObstacles[i].BackgroundImage = Pictures.Milkshake;
                        intObstacleSpeed[i] = 5 + intAddObstacleSpeed;
                        intHitPoints[i] = 3 + intAddObstacleHitPoints;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 45;
                       
                    }
                    //Cake
                    else if (intPicture >= 94 && intPicture <= 102)
                    {
                        pcbObstacles[i].BackgroundImage = Pictures.Cake;
                        intObstacleSpeed[i] = 1 + intAddObstacleSpeed;
                        intHitPoints[i] = 8 + intAddObstacleHitPoints;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                       
                    }
                    //Increase health by 30
                    else if (intPicture == 103)
                    {
                        pcbObstacles[i].BackColor = Color.Brown;
                        pcbObstacles[i].BackgroundImage = Pictures.GainHealth;
                        intObstacleSpeed[i] = 5 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                      
                    }
                    //Decrease health by 20
                    else if (intPicture == 104)
                    {
                        pcbObstacles[i].BackColor = Color.RosyBrown;
                        pcbObstacles[i].BackgroundImage = Pictures.LoseHealth;
                        intObstacleSpeed[i] = 3 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                       
                    }
                    //Increase rocket Speed by 1
                    else if (intPicture == 105)
                    {
                        pcbObstacles[i].BackColor = Color.Chocolate;
                        pcbObstacles[i].BackgroundImage = Pictures.RocketSpeed;
                        intObstacleSpeed[i] = 4 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                       
                    }
                    //Increase Obstacle speed by 1
                    else if (intPicture == 106)
                    {
                       pcbObstacles[i].BackColor = Color.SaddleBrown;
                        pcbObstacles[i].BackgroundImage = Pictures.ObstacleSpeed;
                        intObstacleSpeed[i] = 4 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                       
                    }
                    //Lazer Damage Mulitply by 2
                    else if (intPicture == 107)
                    {
                        pcbObstacles[i].BackColor = Color.Beige;
                        pcbObstacles[i].BackgroundImage = Pictures.LazarDamage;
                        intObstacleSpeed[i] = 5 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
                      
                    }
                    //Add hitpoints on Obstacles
                    else if (intPicture == 108)
                    {
                        pcbObstacles[i].BackColor = Color.Coral;
                        pcbObstacles[i].BackgroundImage = Pictures.Hitpoints;
                        intObstacleSpeed[i] = 3 + intAddObstacleSpeed;
                        intHitPoints[i] = 1;
                        boolObstaclePicture[i] = true;
                        intAngle[i] = 0;
  
                    }
                }

            }
        }
        private void tmr_Game_Tick(object sender, EventArgs e)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: tmr_Game_Tick
            //Purpose: To run all calculations every 1 interval in the game

            BulletMove();
            Intersect();
            ObstaclesMove();
            HealthBar();
            GameHarder();

            this.lblScore.Text = intScore.ToString();
            CheckEndGame();
        }
        public void BulletMove()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 25, 2020
            //Title: BulletMove
            //Purpose: To Move the bullets of the rockets 

            //Bullets
            //Bullets before rocket will allign with centre of y of rocket
            for (int i = 0; i < 48; i++)
            {
                if (pcbLazer[i].Right < this.pcb_Rocket.Right)
                {
                    pcbLazer[i].Top = this.pcb_Rocket.Top + this.pcb_Rocket.Height / 2;
                }
            }

            //Bullets will move towards right, once it hits the end of form, it returns back to the rocket
            for (int i = 0; i < 48; i++)
            {
                if (pcbLazer[i].Right < this.Width)
                {
                    pcbLazer[i].Left += 3;
                }
                else
                {
                    pcbLazer[i].Location = new Point(140, this.pcb_Rocket.Top + this.pcb_Rocket.Height / 2);
                    pcbLazer[i].Visible = true;
                    boolLazerActive[i] = true;
                }
            }
        }
        public void ObstaclesMove()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 26, 2020
            //Title: ObstaclesMove
            //Purpose: To move the Obstacles in the game

            //Variables/Arrays
            int[] intXMove = new int[15];
            int[] intYMove = new int[15];

            //Calculate the direction on distance on each axis for each obstacle
            for (int i = 0; i < 15; i++)
            {
                if (intDirection[i] == 2)
                {
                    intXMove[i] = Math.Abs(XMove(intAngle[i], intObstacleSpeed[i])) * -1;
                    intYMove[i] = Math.Abs(YMove(intAngle[i], intObstacleSpeed[i])) * -1;
                }
                else if (intDirection[i] == 3)
                {
                    intXMove[i] = Math.Abs(XMove(intAngle[i], intObstacleSpeed[i])) * -1;
                    intYMove[i] = Math.Abs(YMove(intAngle[i], intObstacleSpeed[i]));
                }
            }

            //Boundaries, will move in oppsote directions if intersects with the boundries
            for (int i = 0; i < 15; i++)
            {
                //Interseccts top of form
                if (intDirection[i] == 2 && pcbObstacles[i].Top < 0)
                {
                    intDirection[i] = 3;
                }
                //Intersects with the bottom og game play area 
                else if (intDirection[i] == 3 && pcbObstacles[i].Top + pcbObstacles[i].Height > this.pcbBorder.Top)
                {
                    intDirection[i] = 2;
                }
            }

            //Obstacles Move
            for (int i = 0; i < 15; i++)
            {
                //Move the obstacle in their assing direction and distance
                if (pcbObstacles[i].Left > 0)
                {
                    pcbObstacles[i].Left += intXMove[i];
                    pcbObstacles[i].Top += intYMove[i];
                }
                //If the obstacle passes the rocket, it will return to width of form with a new Food for player to kill again
                else
                {
                    //reset location to beggining
                    pcbObstacles[i].Location = new Point(this.Width, i * 30);
                    //Make picturebox visible again
                    pcbObstacles[i].Visible = true;
                    boolObstaclePicture[i] = false;
                    boolObstacleActive[i] = true;
                    //Update Healthbar
                    this.lblHealth.Text = Health(intHitPoints[i]).ToString();
                    //Choose a new Food with new porperties for user to play with
                    ChooseFoodObstacle();
                }
            }

        }
        public int XMove(int intAngle, int intHyp)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 28, 2020
            //Title: XMove
            //Purpose: To calculate the obstacle on x axis

            //Variables
            int intX;

            //Process
            intX = (int)(intHyp * Math.Cos((double)intAngle * Math.PI / 180));
 
            return intX;
        }
        public int YMove(int intAngle, int intHyp)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 28, 2020
            //Title: YMove
            //Purpose: To calculate the obstacle on y axis
            
            //Variables
            int intY;

            //Process
            intY = (int)(intHyp * Math.Sin((double)intAngle * Math.PI / 180));

            return intY;
        }
        public void Intersect()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 28, 2020
            //Title: Intersect
            //Purpose: To run operations if a lazaer intersects with an obstacle
            
            //Check for every lazar
            for (int i = 0; i < 48; i++)
            {
                //Check if that lazar intersects with each obstacles
                for (int j = 0; j < 15; j++)
                {
                    //Condition if lazar interesects with obstacle and both values are active in the game to user
                    if (pcbLazer[i].Left >= pcbObstacles[j].Left && pcbLazer[i].Right <= pcbObstacles[j].Right && pcbLazer[i].Top < pcbObstacles[j].Top + pcbObstacles[j].Height && pcbLazer[i].Top + pcbLazer[i].Height > pcbObstacles[j].Top && boolObstacleActive[j] == true && boolLazerActive[i] == true && intHitPoints[j] != 0)
                    {
                        //Decrease the health of obstacle
                        intHitPoints[j] -= (1 + intAddLazerDamage);

                        //increase score
                        intScore += 10 * (1 + intAddLazerDamage);

                        //Make lazar invisible 
                        pcbLazer[i].Visible = false;
                        boolLazerActive[i] = false;

                        //Directions for computer if addtional health powerup was hit
                        if (pcbObstacles[j].BackColor==Color.Brown && intHealth < 200)
                        {
                            intHealth += 30;
                            this.lblHealth.Text = intHealth.ToString();
                        }
                        //Directions for computer if decrease health powerdown was hit
                        else if (pcbObstacles[j].BackColor == Color.RosyBrown)
                        {
                            intHealth -= 20;
                            this.lblHealth.Text = intHealth.ToString();
                            
                        }
                        //Directions for computer if addtional rocket speed powerup was hit
                        else if (pcbObstacles[j].BackColor == Color.Chocolate && intRocketSpeed < 15 )
                        {
                            intRocketSpeed += 1;
                            //Visiual interpretation to let user know that they have this powerup
                            this.pcbRocketMultiplier.BackgroundImage = Pictures.RocketSpeed;
                            this.lblRocketMulitplierDisplay.Text = "X " + (intRocketSpeed - 10).ToString();
                        }
                        //Directions for computer if addtional obstacle speed powerdown was hit
                        else if (pcbObstacles[j].BackColor == Color.SaddleBrown && intAddObstacleSpeed < 1)
                        {
                            intAddObstacleSpeed += 1;
                            //Visiual interpretation to let user know that they have this powerdown
                            this.pcbObstacleSpeedMultiplier.BackgroundImage = Pictures.ObstacleSpeed;
                            this.lblObstacleSpeedMultiplierDisplay.Text = "X " + intAddObstacleSpeed.ToString();
                        }
                        //Directions for computer if addtional lazar damage powerup was hit
                        else if (pcbObstacles[j].BackColor == Color.Beige && intAddLazerDamage < 1)
                        {
                            intAddLazerDamage += 1;
                            //Visiual interpretation to let user know that they have this powerup
                            this.pcbLazarDamageMultiplier.BackgroundImage = Pictures.LazarDamage;
                            this.lblLazarDamageMultiplierDisplay.Text = "X " + intAddLazerDamage.ToString();
                        }
                        //Directions for computer if addtional obstacle hitpoints powerdown was hit
                        else if (pcbObstacles[j].BackColor == Color.Coral)
                        {
                            intAddObstacleHitPoints += 1;
                            //Visiual interpretation to let user know that they have this powerdown
                            this.pcbObstacleHitpointMultiplier.BackgroundImage = Pictures.Hitpoints;
                            this.lblObstacleHitMultiplierpointsDisplay.Text = "X " + intAddObstacleHitPoints.ToString();
                        }
                    }
                    //If obstacle has no more health, make it invisible to user so user knows that it is dead
                    if (intHitPoints[j] <= 0)
                    {
                        pcbObstacles[j].Visible = false;
                        pcbObstacles[j].BackColor = Color.White;
                        boolObstacleActive[j] = false;    
                    }
                }
            }
        }
        public int Health(int intDeductionFactor)
        {
            //Name: Sathurshan Arulmohan
            //Date: June 29, 2020
            //Title: Health
            //Purpose: To decrease health

            //Makes sure deduction factor is not a negative number
            if (intDeductionFactor < 0)
            {
                intDeductionFactor = 0;
            }

            //Process
            intHealth = intHealth - intDeductionFactor * 10;

            //Makes sure health never goes under 0
            if (intHealth < 0)
            {
                intHealth = 0;
            }

            return intHealth;
        }
        public void HealthBar()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 29, 2020
            //Title: HealthBar
            //Purpose: To visulaly show the user how much health they have

            //Sets up health bar
            this.pcbHealthBar.Size = new Size(intHealth, 25);

            //Sets colours based on health (Green: good; Yellow: warning; Red: Almost dead)
            if (intHealth >= 170)
            {
                this.pcbHealthBar.BackColor = Color.Lime;
            }
            else if (intHealth >= 130 && intHealth < 170)
            {
                this.pcbHealthBar.BackColor = Color.LawnGreen;
            }
            else if (intHealth >= 100 && intHealth < 130)
            {
                this.pcbHealthBar.BackColor = Color.Gold;
            }
            else if (intHealth >= 70 && intHealth < 100)
            {
                this.pcbHealthBar.BackColor = Color.Orange;
            }
            else if (intHealth >= 40 && intHealth < 70)
            {
                this.pcbHealthBar.BackColor = Color.DarkOrange;
            }
            else if (intHealth < 40)
            {
                this.pcbHealthBar.BackColor = Color.Red;
            }
        }
        public void GameHarder()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 29, 2020
            //Title: GameHarder
            //Purpose: Makes the game harder by generating less empty pictureboxes as deffault (this means that more Food obstacles will generate)
            
            //Game difficulty is dependant on player score in realtime game play
            if (intScore > 10000)
            {
                intMinRandom = 40;
                this.lblLevel.Text = "EXPERT";
            }
            else if (intScore > 7500)
            {
                intMinRandom = 30;
                this.lblLevel.Text = "HARD";
            }
            else if (intScore > 5000)
            {
                intMinRandom = 20;
                this.lblLevel.Text = "INTERMEDIATE"; 
            }
            else if (intScore > 2000)
            {
                intMinRandom = 10;           
                this.lblLevel.Text = "Medium";
            }
        }

        public void CheckEndGame()
        {
            //Name: Sathurshan Arulmohan
            //Date: June 29, 2020
            //Title: CheckEndGame
            //Purpose: Check if the game is over

            //If the health is 0, game is over
            if (this.lblHealth.Text == "0")
            {
                //Disable timer
                tmr_Game.Enabled = false;

                //Send score to WinResults and open that form
                WinResults.intFinalScore = intScore;
                WinResults Results = new WinResults();
                this.Hide();
                Results.Show();    
            }
        }
    }
}

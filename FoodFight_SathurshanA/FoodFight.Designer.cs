namespace FoodFight_SathurshanA
{
    partial class FoodFight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_Game = new System.Windows.Forms.Timer(this.components);
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRocketMulitplierDisplay = new System.Windows.Forms.Label();
            this.lblObstacleSpeedMultiplierDisplay = new System.Windows.Forms.Label();
            this.lblLazarDamageMultiplierDisplay = new System.Windows.Forms.Label();
            this.lblObstacleHitMultiplierpointsDisplay = new System.Windows.Forms.Label();
            this.lblHealthDisplay = new System.Windows.Forms.Label();
            this.lblPowerUpsDownTitle = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblLevelTitle = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pcbHealthBar = new System.Windows.Forms.PictureBox();
            this.pcbBackgroundHealth = new System.Windows.Forms.PictureBox();
            this.pcbRocketMultiplier = new System.Windows.Forms.PictureBox();
            this.pcbObstacleHitpointMultiplier = new System.Windows.Forms.PictureBox();
            this.pcbLazarDamageMultiplier = new System.Windows.Forms.PictureBox();
            this.pcbObstacleSpeedMultiplier = new System.Windows.Forms.PictureBox();
            this.pcbBorder = new System.Windows.Forms.PictureBox();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.pcb_Rocket = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHealthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackgroundHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRocketMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacleHitpointMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLazarDamageMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacleSpeedMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_Game
            // 
            this.tmr_Game.Interval = 1;
            this.tmr_Game.Tick += new System.EventHandler(this.tmr_Game_Tick);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Khaki;
            this.lblHealth.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(108, 533);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(32, 17);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "200";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Khaki;
            this.lblScore.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(554, 509);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(24, 28);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // lblRocketMulitplierDisplay
            // 
            this.lblRocketMulitplierDisplay.AutoSize = true;
            this.lblRocketMulitplierDisplay.BackColor = System.Drawing.Color.Khaki;
            this.lblRocketMulitplierDisplay.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRocketMulitplierDisplay.Location = new System.Drawing.Point(295, 509);
            this.lblRocketMulitplierDisplay.Name = "lblRocketMulitplierDisplay";
            this.lblRocketMulitplierDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblRocketMulitplierDisplay.TabIndex = 12;
            // 
            // lblObstacleSpeedMultiplierDisplay
            // 
            this.lblObstacleSpeedMultiplierDisplay.AutoSize = true;
            this.lblObstacleSpeedMultiplierDisplay.BackColor = System.Drawing.Color.Khaki;
            this.lblObstacleSpeedMultiplierDisplay.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObstacleSpeedMultiplierDisplay.Location = new System.Drawing.Point(295, 537);
            this.lblObstacleSpeedMultiplierDisplay.Name = "lblObstacleSpeedMultiplierDisplay";
            this.lblObstacleSpeedMultiplierDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblObstacleSpeedMultiplierDisplay.TabIndex = 13;
            // 
            // lblLazarDamageMultiplierDisplay
            // 
            this.lblLazarDamageMultiplierDisplay.AutoSize = true;
            this.lblLazarDamageMultiplierDisplay.BackColor = System.Drawing.Color.Khaki;
            this.lblLazarDamageMultiplierDisplay.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLazarDamageMultiplierDisplay.Location = new System.Drawing.Point(409, 509);
            this.lblLazarDamageMultiplierDisplay.Name = "lblLazarDamageMultiplierDisplay";
            this.lblLazarDamageMultiplierDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblLazarDamageMultiplierDisplay.TabIndex = 14;
            // 
            // lblObstacleHitMultiplierpointsDisplay
            // 
            this.lblObstacleHitMultiplierpointsDisplay.AutoSize = true;
            this.lblObstacleHitMultiplierpointsDisplay.BackColor = System.Drawing.Color.Khaki;
            this.lblObstacleHitMultiplierpointsDisplay.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObstacleHitMultiplierpointsDisplay.Location = new System.Drawing.Point(409, 537);
            this.lblObstacleHitMultiplierpointsDisplay.Name = "lblObstacleHitMultiplierpointsDisplay";
            this.lblObstacleHitMultiplierpointsDisplay.Size = new System.Drawing.Size(0, 17);
            this.lblObstacleHitMultiplierpointsDisplay.TabIndex = 15;
            // 
            // lblHealthDisplay
            // 
            this.lblHealthDisplay.AutoSize = true;
            this.lblHealthDisplay.BackColor = System.Drawing.Color.Khaki;
            this.lblHealthDisplay.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthDisplay.Location = new System.Drawing.Point(78, 472);
            this.lblHealthDisplay.Name = "lblHealthDisplay";
            this.lblHealthDisplay.Size = new System.Drawing.Size(84, 27);
            this.lblHealthDisplay.TabIndex = 17;
            this.lblHealthDisplay.Text = "HEALTH";
            // 
            // lblPowerUpsDownTitle
            // 
            this.lblPowerUpsDownTitle.AutoSize = true;
            this.lblPowerUpsDownTitle.BackColor = System.Drawing.Color.Khaki;
            this.lblPowerUpsDownTitle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUpsDownTitle.Location = new System.Drawing.Point(259, 472);
            this.lblPowerUpsDownTitle.Name = "lblPowerUpsDownTitle";
            this.lblPowerUpsDownTitle.Size = new System.Drawing.Size(196, 27);
            this.lblPowerUpsDownTitle.TabIndex = 18;
            this.lblPowerUpsDownTitle.Text = "POWER UPS/DOWNS";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.BackColor = System.Drawing.Color.Khaki;
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(554, 473);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(73, 27);
            this.lblScoreTitle.TabIndex = 19;
            this.lblScoreTitle.Text = "SCORE";
            // 
            // lblLevelTitle
            // 
            this.lblLevelTitle.AutoSize = true;
            this.lblLevelTitle.BackColor = System.Drawing.Color.Khaki;
            this.lblLevelTitle.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelTitle.Location = new System.Drawing.Point(732, 473);
            this.lblLevelTitle.Name = "lblLevelTitle";
            this.lblLevelTitle.Size = new System.Drawing.Size(71, 27);
            this.lblLevelTitle.TabIndex = 20;
            this.lblLevelTitle.Text = "LEVEL";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Khaki;
            this.lblLevel.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(733, 509);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 23);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "EASY";
            // 
            // pcbHealthBar
            // 
            this.pcbHealthBar.BackColor = System.Drawing.Color.Lime;
            this.pcbHealthBar.Location = new System.Drawing.Point(5, 501);
            this.pcbHealthBar.Name = "pcbHealthBar";
            this.pcbHealthBar.Size = new System.Drawing.Size(200, 25);
            this.pcbHealthBar.TabIndex = 6;
            this.pcbHealthBar.TabStop = false;
            // 
            // pcbBackgroundHealth
            // 
            this.pcbBackgroundHealth.BackColor = System.Drawing.Color.Khaki;
            this.pcbBackgroundHealth.Location = new System.Drawing.Point(5, 501);
            this.pcbBackgroundHealth.Name = "pcbBackgroundHealth";
            this.pcbBackgroundHealth.Size = new System.Drawing.Size(220, 25);
            this.pcbBackgroundHealth.TabIndex = 22;
            this.pcbBackgroundHealth.TabStop = false;
            // 
            // pcbRocketMultiplier
            // 
            this.pcbRocketMultiplier.BackColor = System.Drawing.Color.Khaki;
            this.pcbRocketMultiplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbRocketMultiplier.Location = new System.Drawing.Point(251, 502);
            this.pcbRocketMultiplier.Name = "pcbRocketMultiplier";
            this.pcbRocketMultiplier.Size = new System.Drawing.Size(25, 25);
            this.pcbRocketMultiplier.TabIndex = 8;
            this.pcbRocketMultiplier.TabStop = false;
            // 
            // pcbObstacleHitpointMultiplier
            // 
            this.pcbObstacleHitpointMultiplier.BackColor = System.Drawing.Color.Khaki;
            this.pcbObstacleHitpointMultiplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbObstacleHitpointMultiplier.Location = new System.Drawing.Point(366, 529);
            this.pcbObstacleHitpointMultiplier.Name = "pcbObstacleHitpointMultiplier";
            this.pcbObstacleHitpointMultiplier.Size = new System.Drawing.Size(25, 25);
            this.pcbObstacleHitpointMultiplier.TabIndex = 11;
            this.pcbObstacleHitpointMultiplier.TabStop = false;
            // 
            // pcbLazarDamageMultiplier
            // 
            this.pcbLazarDamageMultiplier.BackColor = System.Drawing.Color.Khaki;
            this.pcbLazarDamageMultiplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLazarDamageMultiplier.Location = new System.Drawing.Point(366, 502);
            this.pcbLazarDamageMultiplier.Name = "pcbLazarDamageMultiplier";
            this.pcbLazarDamageMultiplier.Size = new System.Drawing.Size(25, 25);
            this.pcbLazarDamageMultiplier.TabIndex = 10;
            this.pcbLazarDamageMultiplier.TabStop = false;
            // 
            // pcbObstacleSpeedMultiplier
            // 
            this.pcbObstacleSpeedMultiplier.BackColor = System.Drawing.Color.Khaki;
            this.pcbObstacleSpeedMultiplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbObstacleSpeedMultiplier.Location = new System.Drawing.Point(251, 529);
            this.pcbObstacleSpeedMultiplier.Name = "pcbObstacleSpeedMultiplier";
            this.pcbObstacleSpeedMultiplier.Size = new System.Drawing.Size(25, 25);
            this.pcbObstacleSpeedMultiplier.TabIndex = 9;
            this.pcbObstacleSpeedMultiplier.TabStop = false;
            // 
            // pcbBorder
            // 
            this.pcbBorder.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbBorder.Location = new System.Drawing.Point(0, 460);
            this.pcbBorder.Name = "pcbBorder";
            this.pcbBorder.Size = new System.Drawing.Size(850, 10);
            this.pcbBorder.TabIndex = 3;
            this.pcbBorder.TabStop = false;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackgroundImage = global::FoodFight_SathurshanA.Pictures.AllButton;
            this.btnPlayGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayGame.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(326, 157);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(194, 110);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "PLAY \r\nGAME";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // pcb_Rocket
            // 
            this.pcb_Rocket.BackColor = System.Drawing.Color.Transparent;
            this.pcb_Rocket.BackgroundImage = global::FoodFight_SathurshanA.Pictures.RocketShip;
            this.pcb_Rocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_Rocket.Location = new System.Drawing.Point(0, 188);
            this.pcb_Rocket.Name = "pcb_Rocket";
            this.pcb_Rocket.Size = new System.Drawing.Size(140, 56);
            this.pcb_Rocket.TabIndex = 0;
            this.pcb_Rocket.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::FoodFight_SathurshanA.Pictures.AllButton;
            this.pictureBox5.Location = new System.Drawing.Point(0, 470);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(850, 93);
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // FoodFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(849, 559);
            this.Controls.Add(this.pcbHealthBar);
            this.Controls.Add(this.pcbBackgroundHealth);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblLevelTitle);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblPowerUpsDownTitle);
            this.Controls.Add(this.lblHealthDisplay);
            this.Controls.Add(this.pcbRocketMultiplier);
            this.Controls.Add(this.lblObstacleHitMultiplierpointsDisplay);
            this.Controls.Add(this.lblLazarDamageMultiplierDisplay);
            this.Controls.Add(this.lblObstacleSpeedMultiplierDisplay);
            this.Controls.Add(this.lblRocketMulitplierDisplay);
            this.Controls.Add(this.pcbObstacleHitpointMultiplier);
            this.Controls.Add(this.pcbLazarDamageMultiplier);
            this.Controls.Add(this.pcbObstacleSpeedMultiplier);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pcbBorder);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.pcb_Rocket);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FoodFight";
            this.Text = "FOOD FIGHT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_FoodFight_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHealthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackgroundHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRocketMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacleHitpointMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLazarDamageMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacleSpeedMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Rocket;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Timer tmr_Game;
        private System.Windows.Forms.PictureBox pcbBorder;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pcbHealthBar;
        private System.Windows.Forms.PictureBox pcbRocketMultiplier;
        private System.Windows.Forms.PictureBox pcbObstacleSpeedMultiplier;
        private System.Windows.Forms.PictureBox pcbLazarDamageMultiplier;
        private System.Windows.Forms.PictureBox pcbObstacleHitpointMultiplier;
        private System.Windows.Forms.Label lblRocketMulitplierDisplay;
        private System.Windows.Forms.Label lblObstacleSpeedMultiplierDisplay;
        private System.Windows.Forms.Label lblLazarDamageMultiplierDisplay;
        private System.Windows.Forms.Label lblObstacleHitMultiplierpointsDisplay;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblHealthDisplay;
        private System.Windows.Forms.Label lblPowerUpsDownTitle;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblLevelTitle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox pcbBackgroundHealth;
    }
}


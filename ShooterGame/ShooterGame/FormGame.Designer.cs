namespace ShooterGame
{
    partial class FormGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            picEnemy = new PictureBox();
            picPlayer = new PictureBox();
            picEnemyBullet = new PictureBox();
            picPlayerHP = new PictureBox();
            picEnemyHP = new PictureBox();
            picPlayerBullet = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblResult = new Label();
            lblScoreResult = new Label();
            ((System.ComponentModel.ISupportInitialize)picEnemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyBullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerBullet).BeginInit();
            SuspendLayout();
            // 
            // picEnemy
            // 
            picEnemy.BackColor = Color.Transparent;
            picEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            picEnemy.Location = new Point(930, 324);
            picEnemy.Name = "picEnemy";
            picEnemy.Size = new Size(396, 454);
            picEnemy.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemy.TabIndex = 1;
            picEnemy.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Transparent;
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Location = new Point(180, 450);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(206, 258);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 2;
            picPlayer.TabStop = false;
            // 
            // picEnemyBullet
            // 
            picEnemyBullet.BackColor = Color.Transparent;
            picEnemyBullet.BackgroundImageLayout = ImageLayout.Stretch;
            picEnemyBullet.Location = new Point(830, 469);
            picEnemyBullet.Name = "picEnemyBullet";
            picEnemyBullet.Size = new Size(126, 88);
            picEnemyBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyBullet.TabIndex = 3;
            picEnemyBullet.TabStop = false;
            // 
            // picPlayerHP
            // 
            picPlayerHP.BackColor = Color.Transparent;
            picPlayerHP.Location = new Point(-1, 12);
            picPlayerHP.Name = "picPlayerHP";
            picPlayerHP.Size = new Size(423, 159);
            picPlayerHP.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerHP.TabIndex = 4;
            picPlayerHP.TabStop = false;
            // 
            // picEnemyHP
            // 
            picEnemyHP.BackColor = Color.Transparent;
            picEnemyHP.Location = new Point(879, -1);
            picEnemyHP.Name = "picEnemyHP";
            picEnemyHP.Size = new Size(581, 170);
            picEnemyHP.SizeMode = PictureBoxSizeMode.StretchImage;
            picEnemyHP.TabIndex = 5;
            picEnemyHP.TabStop = false;
            // 
            // picPlayerBullet
            // 
            picPlayerBullet.BackColor = Color.Transparent;
            picPlayerBullet.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayerBullet.Location = new Point(381, 507);
            picPlayerBullet.Name = "picPlayerBullet";
            picPlayerBullet.Size = new Size(100, 88);
            picPlayerBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayerBullet.TabIndex = 6;
            picPlayerBullet.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Tempus Sans ITC", 38F, FontStyle.Bold | FontStyle.Italic);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(290, 222);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(823, 167);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreResult
            // 
            lblScoreResult.AutoSize = true;
            lblScoreResult.BackColor = Color.Transparent;
            lblScoreResult.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreResult.ForeColor = Color.Red;
            lblScoreResult.Location = new Point(407, 731);
            lblScoreResult.Name = "lblScoreResult";
            lblScoreResult.Size = new Size(0, 62);
            lblScoreResult.TabIndex = 8;
            lblScoreResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1455, 944);
            Controls.Add(lblScoreResult);
            Controls.Add(lblResult);
            Controls.Add(picEnemyBullet);
            Controls.Add(picPlayerBullet);
            Controls.Add(picEnemyHP);
            Controls.Add(picPlayer);
            Controls.Add(picPlayerHP);
            Controls.Add(picEnemy);
            Name = "FormGame";
            Load += FormGame_Load;
            ((System.ComponentModel.ISupportInitialize)picEnemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyBullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEnemyHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerBullet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picEnemy;
        private PictureBox picPlayer;
        private PictureBox picEnemyBullet;
        private PictureBox picPlayerHP;
        private PictureBox picEnemyHP;
        private PictureBox picPlayerBullet;
        private System.Windows.Forms.Timer timer1;
        private Label lblResult;
        private Label lblScoreResult;
    }
}
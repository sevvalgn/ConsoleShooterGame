namespace ShooterGame
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            picbtnStart = new PictureBox();
            picbtnLeaderboard = new PictureBox();
            picbtnExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbtnStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbtnLeaderboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbtnExit).BeginInit();
            SuspendLayout();
            // 
            // picbtnStart
            // 
            picbtnStart.BackColor = Color.Transparent;
            picbtnStart.Cursor = Cursors.Hand;
            picbtnStart.Image = (Image)resources.GetObject("picbtnStart.Image");
            picbtnStart.Location = new Point(897, 32);
            picbtnStart.Name = "picbtnStart";
            picbtnStart.Size = new Size(501, 100);
            picbtnStart.SizeMode = PictureBoxSizeMode.StretchImage;
            picbtnStart.TabIndex = 5;
            picbtnStart.TabStop = false;
            picbtnStart.Click += picbtnStart_Click;
            // 
            // picbtnLeaderboard
            // 
            picbtnLeaderboard.BackColor = Color.Transparent;
            picbtnLeaderboard.Cursor = Cursors.Hand;
            picbtnLeaderboard.Image = (Image)resources.GetObject("picbtnLeaderboard.Image");
            picbtnLeaderboard.Location = new Point(897, 147);
            picbtnLeaderboard.Name = "picbtnLeaderboard";
            picbtnLeaderboard.Size = new Size(501, 108);
            picbtnLeaderboard.SizeMode = PictureBoxSizeMode.StretchImage;
            picbtnLeaderboard.TabIndex = 6;
            picbtnLeaderboard.TabStop = false;
            picbtnLeaderboard.Click += picbtnLeaderboard_Click;
            // 
            // picbtnExit
            // 
            picbtnExit.BackColor = Color.Transparent;
            picbtnExit.Cursor = Cursors.Hand;
            picbtnExit.Image = (Image)resources.GetObject("picbtnExit.Image");
            picbtnExit.Location = new Point(897, 272);
            picbtnExit.Name = "picbtnExit";
            picbtnExit.Size = new Size(501, 100);
            picbtnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            picbtnExit.TabIndex = 7;
            picbtnExit.TabStop = false;
            picbtnExit.Click += picbtnExit_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1446, 828);
            Controls.Add(picbtnExit);
            Controls.Add(picbtnLeaderboard);
            Controls.Add(picbtnStart);
            DoubleBuffered = true;
            Name = "FormMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)picbtnStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbtnLeaderboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbtnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picbtnStart;
        private PictureBox picbtnLeaderboard;
        private PictureBox picbtnExit;
    }
}
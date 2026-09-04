namespace ShooterGame
{
    partial class FormCharacterChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterChoice));
            picFairy = new PictureBox();
            picSoldier = new PictureBox();
            picOldman = new PictureBox();
            lblChooseCharacter = new Label();
            lblFairyHealth = new Label();
            lblFairyAttack = new Label();
            label1 = new Label();
            lblSoldierHealth = new Label();
            lblSoldierAttack = new Label();
            lblOldmanHealth = new Label();
            lblOldmanAttack = new Label();
            lblSoldier = new Label();
            lblOldman = new Label();
            ((System.ComponentModel.ISupportInitialize)picFairy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSoldier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOldman).BeginInit();
            SuspendLayout();
            // 
            // picFairy
            // 
            picFairy.Cursor = Cursors.Hand;
            picFairy.Image = (Image)resources.GetObject("picFairy.Image");
            picFairy.Location = new Point(225, 236);
            picFairy.Name = "picFairy";
            picFairy.Size = new Size(274, 288);
            picFairy.SizeMode = PictureBoxSizeMode.StretchImage;
            picFairy.TabIndex = 0;
            picFairy.TabStop = false;
            picFairy.Click += picFairy_Click;
            picFairy.MouseEnter += picFairy_MouseEnter;
            picFairy.MouseLeave += picFairy_MouseLeave;
            // 
            // picSoldier
            // 
            picSoldier.Cursor = Cursors.Hand;
            picSoldier.Image = (Image)resources.GetObject("picSoldier.Image");
            picSoldier.Location = new Point(597, 236);
            picSoldier.Name = "picSoldier";
            picSoldier.Size = new Size(274, 288);
            picSoldier.SizeMode = PictureBoxSizeMode.StretchImage;
            picSoldier.TabIndex = 1;
            picSoldier.TabStop = false;
            picSoldier.Click += picSoldier_Click;
            picSoldier.MouseEnter += picSoldier_MouseEnter;
            picSoldier.MouseLeave += picSoldier_MouseLeave;
            // 
            // picOldman
            // 
            picOldman.Cursor = Cursors.Hand;
            picOldman.Image = (Image)resources.GetObject("picOldman.Image");
            picOldman.Location = new Point(953, 236);
            picOldman.Name = "picOldman";
            picOldman.Size = new Size(274, 288);
            picOldman.SizeMode = PictureBoxSizeMode.StretchImage;
            picOldman.TabIndex = 2;
            picOldman.TabStop = false;
            picOldman.Click += picOldman_Click;
            picOldman.MouseEnter += picOldman_MouseEnter;
            picOldman.MouseLeave += picOldman_MouseLeave;
            // 
            // lblChooseCharacter
            // 
            lblChooseCharacter.AutoSize = true;
            lblChooseCharacter.Font = new Font("Tempus Sans ITC", 22.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseCharacter.ForeColor = Color.GreenYellow;
            lblChooseCharacter.Location = new Point(380, 82);
            lblChooseCharacter.Name = "lblChooseCharacter";
            lblChooseCharacter.Size = new Size(718, 80);
            lblChooseCharacter.TabIndex = 3;
            lblChooseCharacter.Text = "Please choose a character!";
            // 
            // lblFairyHealth
            // 
            lblFairyHealth.AutoSize = true;
            lblFairyHealth.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFairyHealth.ForeColor = Color.FromArgb(255, 255, 128);
            lblFairyHealth.Location = new Point(243, 616);
            lblFairyHealth.Name = "lblFairyHealth";
            lblFairyHealth.Size = new Size(223, 49);
            lblFairyHealth.TabIndex = 4;
            lblFairyHealth.Text = "Health : 800";
            lblFairyHealth.Visible = false;
            // 
            // lblFairyAttack
            // 
            lblFairyAttack.AutoSize = true;
            lblFairyAttack.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFairyAttack.ForeColor = Color.FromArgb(255, 255, 128);
            lblFairyAttack.Location = new Point(243, 680);
            lblFairyAttack.Name = "lblFairyAttack";
            lblFairyAttack.Size = new Size(219, 49);
            lblFairyAttack.TabIndex = 5;
            lblFairyAttack.Text = "Attack : 250";
            lblFairyAttack.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Olive;
            label1.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(309, 527);
            label1.Name = "label1";
            label1.Size = new Size(99, 49);
            label1.TabIndex = 6;
            label1.Text = "Fairy";
            // 
            // lblSoldierHealth
            // 
            lblSoldierHealth.AutoSize = true;
            lblSoldierHealth.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoldierHealth.ForeColor = Color.FromArgb(128, 255, 128);
            lblSoldierHealth.Location = new Point(617, 616);
            lblSoldierHealth.Name = "lblSoldierHealth";
            lblSoldierHealth.Size = new Size(222, 49);
            lblSoldierHealth.TabIndex = 7;
            lblSoldierHealth.Text = "Health : 500";
            lblSoldierHealth.Visible = false;
            // 
            // lblSoldierAttack
            // 
            lblSoldierAttack.AutoSize = true;
            lblSoldierAttack.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoldierAttack.ForeColor = Color.FromArgb(128, 255, 128);
            lblSoldierAttack.Location = new Point(618, 680);
            lblSoldierAttack.Name = "lblSoldierAttack";
            lblSoldierAttack.Size = new Size(223, 49);
            lblSoldierAttack.TabIndex = 8;
            lblSoldierAttack.Text = "Attack : 500";
            lblSoldierAttack.Visible = false;
            // 
            // lblOldmanHealth
            // 
            lblOldmanHealth.AutoSize = true;
            lblOldmanHealth.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldmanHealth.ForeColor = Color.Brown;
            lblOldmanHealth.Location = new Point(984, 616);
            lblOldmanHealth.Name = "lblOldmanHealth";
            lblOldmanHealth.Size = new Size(221, 49);
            lblOldmanHealth.TabIndex = 9;
            lblOldmanHealth.Text = "Health : 300";
            lblOldmanHealth.Visible = false;
            // 
            // lblOldmanAttack
            // 
            lblOldmanAttack.AutoSize = true;
            lblOldmanAttack.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldmanAttack.ForeColor = Color.Brown;
            lblOldmanAttack.Location = new Point(984, 680);
            lblOldmanAttack.Name = "lblOldmanAttack";
            lblOldmanAttack.Size = new Size(243, 49);
            lblOldmanAttack.TabIndex = 10;
            lblOldmanAttack.Text = "Attack : 1000";
            lblOldmanAttack.Visible = false;
            // 
            // lblSoldier
            // 
            lblSoldier.AutoSize = true;
            lblSoldier.BackColor = Color.Olive;
            lblSoldier.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoldier.ForeColor = Color.FromArgb(192, 255, 192);
            lblSoldier.Location = new Point(668, 527);
            lblSoldier.Name = "lblSoldier";
            lblSoldier.Size = new Size(128, 49);
            lblSoldier.TabIndex = 11;
            lblSoldier.Text = "Soldier";
            // 
            // lblOldman
            // 
            lblOldman.AutoSize = true;
            lblOldman.BackColor = Color.Olive;
            lblOldman.Font = new Font("Tempus Sans ITC", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldman.ForeColor = Color.Firebrick;
            lblOldman.Location = new Point(1015, 527);
            lblOldman.Name = "lblOldman";
            lblOldman.Size = new Size(149, 49);
            lblOldman.TabIndex = 12;
            lblOldman.Text = "Oldman";
            // 
            // FormCharacterChoice
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(1450, 892);
            Controls.Add(lblOldman);
            Controls.Add(lblSoldier);
            Controls.Add(lblOldmanAttack);
            Controls.Add(lblOldmanHealth);
            Controls.Add(lblSoldierAttack);
            Controls.Add(lblSoldierHealth);
            Controls.Add(label1);
            Controls.Add(lblFairyAttack);
            Controls.Add(lblFairyHealth);
            Controls.Add(lblChooseCharacter);
            Controls.Add(picOldman);
            Controls.Add(picSoldier);
            Controls.Add(picFairy);
            Name = "FormCharacterChoice";
            Text = "Choose Your Character";
            ((System.ComponentModel.ISupportInitialize)picFairy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSoldier).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOldman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picFairy;
        private PictureBox picSoldier;
        private PictureBox picOldman;
        private Label lblChooseCharacter;
        private Label lblFairyHealth;
        private Label lblFairyAttack;
        private Label label1;
        private Label lblSoldierHealth;
        private Label lblSoldierAttack;
        private Label lblOldmanHealth;
        private Label lblOldmanAttack;
        private Label lblSoldier;
        private Label lblOldman;
    }
}
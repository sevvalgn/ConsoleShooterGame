namespace ShooterGame
{
    partial class FormRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            lblRegister = new Label();
            lblName = new Label();
            lblPwd = new Label();
            lblPwdAgain = new Label();
            txtboxName = new TextBox();
            txtboxPwd = new TextBox();
            txtboxPwdAgain = new TextBox();
            btnBacktoLogin = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Tempus Sans ITC", 15F, FontStyle.Bold);
            btnRegister.Location = new Point(701, 527);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(380, 84);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register and Login";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegister
            // 
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Tempus Sans ITC", 25F, FontStyle.Bold | FontStyle.Underline);
            lblRegister.ForeColor = Color.White;
            lblRegister.ImageAlign = ContentAlignment.MiddleRight;
            lblRegister.Location = new Point(546, 103);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(568, 90);
            lblRegister.TabIndex = 1;
            lblRegister.Text = "Registration Page";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Tempus Sans ITC", 13F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(560, 257);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 46);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.BackColor = Color.Transparent;
            lblPwd.Font = new Font("Tempus Sans ITC", 13F, FontStyle.Bold);
            lblPwd.ForeColor = Color.White;
            lblPwd.Location = new Point(560, 338);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(293, 46);
            lblPwd.TabIndex = 3;
            lblPwd.Text = "Create a password";
            // 
            // lblPwdAgain
            // 
            lblPwdAgain.AutoSize = true;
            lblPwdAgain.BackColor = Color.Transparent;
            lblPwdAgain.Font = new Font("Tempus Sans ITC", 13F, FontStyle.Bold);
            lblPwdAgain.ForeColor = Color.White;
            lblPwdAgain.Location = new Point(560, 422);
            lblPwdAgain.Name = "lblPwdAgain";
            lblPwdAgain.Size = new Size(428, 46);
            lblPwdAgain.TabIndex = 4;
            lblPwdAgain.Text = "Enter your password again";
            // 
            // txtboxName
            // 
            txtboxName.Cursor = Cursors.IBeam;
            txtboxName.Location = new Point(994, 264);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(208, 39);
            txtboxName.TabIndex = 5;
            // 
            // txtboxPwd
            // 
            txtboxPwd.Cursor = Cursors.IBeam;
            txtboxPwd.Location = new Point(994, 338);
            txtboxPwd.Name = "txtboxPwd";
            txtboxPwd.PasswordChar = '*';
            txtboxPwd.Size = new Size(208, 39);
            txtboxPwd.TabIndex = 6;
            // 
            // txtboxPwdAgain
            // 
            txtboxPwdAgain.Cursor = Cursors.IBeam;
            txtboxPwdAgain.Location = new Point(994, 422);
            txtboxPwdAgain.Name = "txtboxPwdAgain";
            txtboxPwdAgain.PasswordChar = '*';
            txtboxPwdAgain.Size = new Size(208, 39);
            txtboxPwdAgain.TabIndex = 7;
            // 
            // btnBacktoLogin
            // 
            btnBacktoLogin.Cursor = Cursors.Hand;
            btnBacktoLogin.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Bold);
            btnBacktoLogin.Location = new Point(54, 820);
            btnBacktoLogin.Name = "btnBacktoLogin";
            btnBacktoLogin.Size = new Size(226, 46);
            btnBacktoLogin.TabIndex = 8;
            btnBacktoLogin.Text = "<<<Back to Login";
            btnBacktoLogin.UseVisualStyleBackColor = true;
            btnBacktoLogin.Click += btnBacktoLogin_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundRegister;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1463, 930);
            Controls.Add(btnBacktoLogin);
            Controls.Add(txtboxPwdAgain);
            Controls.Add(txtboxPwd);
            Controls.Add(txtboxName);
            Controls.Add(lblPwdAgain);
            Controls.Add(lblPwd);
            Controls.Add(lblName);
            Controls.Add(lblRegister);
            Controls.Add(btnRegister);
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label lblRegister;
        private Label lblName;
        private Label lblPwd;
        private Label lblPwdAgain;
        private TextBox txtboxName;
        private TextBox txtboxPwd;
        private TextBox txtboxPwdAgain;
        private Button btnBacktoLogin;
    }
}

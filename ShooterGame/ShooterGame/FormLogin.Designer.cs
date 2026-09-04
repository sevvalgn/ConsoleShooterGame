namespace ShooterGame
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblWelcome = new Label();
            lblLogin = new Label();
            lblName = new Label();
            lblPwd = new Label();
            txtboxName = new TextBox();
            txtboxPwd = new TextBox();
            lblAskAccount = new Label();
            lblAccount = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Tempus Sans ITC", 27F, FontStyle.Bold | FontStyle.Underline);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(212, 88);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(702, 94);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome To Shooter";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Tempus Sans ITC", 22.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(501, 194);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(818, 77);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Please Login To Your Account";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(450, 353);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 42);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.BackColor = Color.Transparent;
            lblPwd.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold);
            lblPwd.ForeColor = Color.White;
            lblPwd.Location = new Point(432, 415);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(148, 42);
            lblPwd.TabIndex = 3;
            lblPwd.Text = "Password";
            // 
            // txtboxName
            // 
            txtboxName.Cursor = Cursors.IBeam;
            txtboxName.Font = new Font("Tempus Sans ITC", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxName.Location = new Point(598, 355);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(328, 43);
            txtboxName.TabIndex = 4;
            // 
            // txtboxPwd
            // 
            txtboxPwd.Cursor = Cursors.IBeam;
            txtboxPwd.Font = new Font("Tempus Sans ITC", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPwd.Location = new Point(598, 414);
            txtboxPwd.Name = "txtboxPwd";
            txtboxPwd.PasswordChar = '*';
            txtboxPwd.Size = new Size(328, 43);
            txtboxPwd.TabIndex = 5;
            // 
            // lblAskAccount
            // 
            lblAskAccount.AutoSize = true;
            lblAskAccount.BackColor = Color.Transparent;
            lblAskAccount.Font = new Font("Tempus Sans ITC", 15F, FontStyle.Bold | FontStyle.Italic);
            lblAskAccount.ForeColor = Color.White;
            lblAskAccount.Location = new Point(763, 797);
            lblAskAccount.Name = "lblAskAccount";
            lblAskAccount.Size = new Size(435, 53);
            lblAskAccount.TabIndex = 6;
            lblAskAccount.Text = "Don't have an              ?";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.BackColor = Color.Transparent;
            lblAccount.Font = new Font("Tempus Sans ITC", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout);
            lblAccount.ForeColor = Color.White;
            lblAccount.Location = new Point(1015, 797);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(163, 53);
            lblAccount.TabIndex = 7;
            lblAccount.Text = "account";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Olive;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(756, 493);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 62);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Olive;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Tempus Sans ITC", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(1204, 797);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 46);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1442, 896);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblAccount);
            Controls.Add(lblAskAccount);
            Controls.Add(txtboxPwd);
            Controls.Add(txtboxName);
            Controls.Add(lblPwd);
            Controls.Add(lblName);
            Controls.Add(lblLogin);
            Controls.Add(lblWelcome);
            DoubleBuffered = true;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblLogin;
        private Label lblName;
        private Label lblPwd;
        private TextBox txtboxName;
        private TextBox txtboxPwd;
        private Label lblAskAccount;
        private Label lblAccount;
        private Button btnLogin;
        private Button btnRegister;
    }
}

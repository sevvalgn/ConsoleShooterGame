namespace ShooterGame
{
    partial class FormFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeedback));
            pictureBox1 = new PictureBox();
            txtboxfeedback = new TextBox();
            btnSend = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 609);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtboxfeedback
            // 
            txtboxfeedback.BackColor = Color.PaleGoldenrod;
            txtboxfeedback.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtboxfeedback.Location = new Point(611, 272);
            txtboxfeedback.Multiline = true;
            txtboxfeedback.Name = "txtboxfeedback";
            txtboxfeedback.PlaceholderText = "Share your thoughts..";
            txtboxfeedback.Size = new Size(547, 233);
            txtboxfeedback.TabIndex = 1;
            txtboxfeedback.TabStop = false;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.DarkKhaki;
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(773, 620);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(211, 73);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send ";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Font = new Font("Tempus Sans ITC", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 44);
            button1.Name = "button1";
            button1.Size = new Size(193, 51);
            button1.TabIndex = 3;
            button1.Text = "<<Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormFeedback
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1469, 950);
            Controls.Add(button1);
            Controls.Add(btnSend);
            Controls.Add(txtboxfeedback);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ControlText;
            Name = "FormFeedback";
            Text = "Give feedback!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtboxfeedback;
        private Button btnSend;
        private Button button1;
    }
}
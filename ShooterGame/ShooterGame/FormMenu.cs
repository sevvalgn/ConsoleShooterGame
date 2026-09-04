using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class FormMenu : Form
    {
        private string playerName;
        public FormMenu(string playerName)
        {

            InitializeComponent();
            this.playerName = playerName;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundMenu.png");
        }

        private void picbtnStart_Click(object sender, EventArgs e)
        {
            //hide menu, show characterchoice
            this.Hide();
            FormCharacterChoice characterchoice = new FormCharacterChoice(this, playerName);
            characterchoice.Show();
        }

        private void picbtnLeaderboard_Click(object sender, EventArgs e)
        {
            //hide menu, show leaderboard
            this.Hide();
            FormLeaderboard leaderboard = new FormLeaderboard(this, playerName);
            leaderboard.Show();
        }

        private void picbtnExit_Click(object sender, EventArgs e)
        {
            //exit the program
            Application.Exit();
        }
    }
}
